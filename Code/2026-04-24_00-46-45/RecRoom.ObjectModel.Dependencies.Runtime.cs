using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Cpp2IlInjected;
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
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9B83D30", Offset = "0x9B82730", VA = "0x189B83D30")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class YKXBFGPKFMQ
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
	[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
	public YKXBFGPKFMQ()
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
		[Cpp2IlInjected.Address(RVA = "0x9B83C30", Offset = "0x9B82630", VA = "0x189B83C30", Slot = "4")]
		public override void WSFSWRIEDET()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD3AE50", Offset = "0xD39850", VA = "0x180D3AE50")]
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
		private int[] YLRGDEQABQS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] YLWNALJXLCB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset KVULHZCLSVL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset KVPEKSIOJKC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] BBTNQITVGYQ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD161A0", Offset = "0xD14BA0", VA = "0x180D161A0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x226C780", Offset = "0x226B180", VA = "0x18226C780", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9B85DB0", Offset = "0x9B847B0", VA = "0x189B85DB0")]
		private void AWUQDEJRHIB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9B85AA0", Offset = "0x9B844A0", VA = "0x189B85AA0")]
		private void AWPJFXPTXWS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9B86160", Offset = "0x9B84B60", VA = "0x189B86160", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9B86210", Offset = "0x9B84C10", VA = "0x189B86210")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(KYJWXBQWXDJ), new string[] { "Photon" })]
	public class KFLQTSQSEMO : KYJWXBQWXDJ
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class EWQRCWWKBDC : BSSIHCSOCMP
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public EPOORIVUAQX SDSBTNUFTAW;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public AELTZKTDOJR ZTYIBVHURQH;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType AFHKRTOWHTU
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x9B82AA0", Offset = "0x9B814A0", VA = "0x189B82AA0", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId LQTBMJMCXTJ
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x9B82CB0", Offset = "0x9B816B0", VA = "0x189B82CB0", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool KLXHHREEHLK
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD5C320", Offset = "0xD5AD20", VA = "0x180D5C320", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool QXPPWRVMCQT
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x9B82770", Offset = "0x9B81170", VA = "0x189B82770", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9B82AF0", Offset = "0x9B814F0", VA = "0x189B82AF0", Slot = "9")]
			public bool TCIVMNVLZQU([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD11BF0", Offset = "0xD105F0", VA = "0x180D11BF0", Slot = "8")]
			public object DQWRCBPUVEG()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9B825E0", Offset = "0x9B80FE0", VA = "0x189B825E0", Slot = "10")]
			private (PlayerId, object) GBZEZCYAMZI()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9B82250", Offset = "0x9B80C50", VA = "0x189B82250", Slot = "11")]
			private (ObjectNetworkId, PlayerId) EIMVZHEDMBQ()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9B82970", Offset = "0x9B81370", VA = "0x189B82970", Slot = "12")]
			private CARLOPMWKZV<(ObjectNetworkId, PlayerId)> MYCKLKFIOAB()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9B82020", Offset = "0x9B80A20", VA = "0x189B82020", Slot = "13")]
			private (OutOfBandMessageType, byte[]) DXHCGYPSCJX()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9B82340", Offset = "0x9B80D40", VA = "0x189B82340", Slot = "14")]
			private (PacketSource, byte[]) EQFAUQDTEKO()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4193E40", Offset = "0x4192840", VA = "0x184193E40", Slot = "15")]
			public a XCAXTOUELRL<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9B82BC0", Offset = "0x9B815C0", VA = "0x189B82BC0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public EWQRCWWKBDC()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class AELTZKTDOJR : CARLOPMWKZV<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] SFYTCFWFQLG;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int XNBAVDEQHQO
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x9B80670", Offset = "0x9B7F070", VA = "0x189B80670", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x9B80690", Offset = "0x9B7F090", VA = "0x189B80690", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public AELTZKTDOJR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9B83790", Offset = "0x9B82190", VA = "0x189B83790", Slot = "4")]
		public bool YMUWMWJPKES(object a, BSSIHCSOCMP b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
		public KFLQTSQSEMO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class IBRWWXIVNUB
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(YQHBIUJFLQS), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : YMKBVOLYXIE, DUHJSGRNEWU, YQHBIUJFLQS, KZDQEQUQNCZ, PGANNZBSSYB
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log WVPIFBCBMJC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private MNRZCGJJRBK DQLZWBXICZJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private UVZWJYSRBFR PNNCZYSIDYX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> XJEZXIZHVPZ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9B84A00", Offset = "0x9B83400", VA = "0x189B84A00", Slot = "4")]
		public void InitReferences(VBPLBVQDNMR services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9B84F40", Offset = "0x9B83940", VA = "0x189B84F40", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9B84D50", Offset = "0x9B83750", VA = "0x189B84D50", Slot = "6")]
		public void RGNKCPLUGBH(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9B84880", Offset = "0x9B83280", VA = "0x189B84880", Slot = "10")]
		public void ICUOWDQRGFQ(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9B84B40", Offset = "0x9B83540", VA = "0x189B84B40", Slot = "7")]
		public void NVLJJPWKNRV(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9B84560", Offset = "0x9B82F60", VA = "0x189B84560")]
		private IDictionary<object, object> HHFLNSODDSG(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9B84AE0", Offset = "0x9B834E0", VA = "0x189B84AE0")]
		public void MZPDYTEMTXD(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9B84FE0", Offset = "0x9B839E0", VA = "0x189B84FE0", Slot = "8")]
		private void UBCVDPRMWRT(VBPLBVQDNMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x104F8B0", Offset = "0x104E2B0", VA = "0x18104F8B0", Slot = "9")]
		private void UYXNLSZGBZH()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9B850E0", Offset = "0x9B83AE0", VA = "0x189B850E0")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.HVUYDECOCTL), new string[] { })]
	internal class GOCDWSMWJHC : KAVZVXNLXGW, RecRoom.RoomLoading.RoomOperation.HVUYDECOCTL
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log KYFQUJELSHV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] COZILMXTWIY
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9B82D50", Offset = "0x9B81750", VA = "0x189B82D50")]
		public GOCDWSMWJHC()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class KJFHYVVVPBF : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9B838A0", Offset = "0x9B822A0", VA = "0x189B838A0", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9B83AA0", Offset = "0x9B824A0", VA = "0x189B83AA0")]
		public KJFHYVVVPBF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class KCCCEXFZJQA
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KMORFLEWRJL
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings OAEXPITHCNN;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD179B0", Offset = "0xD163B0", VA = "0x180D179B0")]
			public KMORFLEWRJL()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9B83AF0", Offset = "0x9B824F0", VA = "0x189B83AF0")]
			internal string AIFZPZVIZPA(EPOORIVUAQX a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9B83770", Offset = "0x9B82170", VA = "0x189B83770")]
		public static string XAHKSLCGLZO(this EPOORIVUAQX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9B83410", Offset = "0x9B81E10", VA = "0x189B83410")]
		public static NetworkEventType RWXBBZSVCQH(this EPOORIVUAQX a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9B83550", Offset = "0x9B81F50", VA = "0x189B83550")]
		public static ViewId UDQZWJOZCKS(this EPOORIVUAQX a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9B831F0", Offset = "0x9B81BF0", VA = "0x189B831F0")]
		public static string QDOSFUFKFVC(this EPOORIVUAQX a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9B83100", Offset = "0x9B81B00", VA = "0x189B83100")]
		private static string PAADVNNNVGS(EPOORIVUAQX a, Func<EPOORIVUAQX, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9B832B0", Offset = "0x9B81CB0", VA = "0x189B832B0")]
		public static string QOBNDHIUJZQ(this EPOORIVUAQX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9B82E00", Offset = "0x9B81800", VA = "0x189B82E00")]
		public static ViewId JYGXSXPDZRB(this EPOORIVUAQX a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9B82FF0", Offset = "0x9B819F0", VA = "0x189B82FF0")]
		public static string MUIQXNREHOV(this EPOORIVUAQX a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class SWNEDGBNVFS
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class CSKHNWGKNPC
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string STWIIHPYAQH;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9B85160", Offset = "0x9B83B60", VA = "0x189B85160")]
		public static string NGKUPBGXJPZ(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(PGUAJCSQPAR), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class PGUAJCSQPAR : KAVZVXNLXGW
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log LMCLSJPABCC;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log JGBGWFDOSER;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log COBQQGIXDGD;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] COZILMXTWIY
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD11BE0", Offset = "0xD105E0", VA = "0x180D11BE0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9B83F30", Offset = "0x9B82930", VA = "0x189B83F30", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9B83DB0", Offset = "0x9B827B0", VA = "0x189B83DB0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9B840B0", Offset = "0x9B82AB0", VA = "0x189B840B0")]
		private void RBYDUXILGLE(EPOORIVUAQX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9B840C0", Offset = "0x9B82AC0", VA = "0x189B840C0")]
		private void RGIJIADDOFN(EPOORIVUAQX a, CBEOKZVPQNC b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9B840F0", Offset = "0x9B82AF0", VA = "0x189B840F0")]
		public void TTQEJWPKQQB(EPOORIVUAQX a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9B84310", Offset = "0x9B82D10", VA = "0x189B84310")]
		private static Log YMHLOYTMZBJ(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9B84470", Offset = "0x9B82E70", VA = "0x189B84470")]
		public PGUAJCSQPAR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class AMHOOWMOUDK
	{
		[StructLayout((LayoutKind)3)]
		[Cpp2IlInjected.Token(Token = "0x2000018")]
		[CompilerGenerated]
		private struct <>c__DisplayClass6_0
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x0")]
			[Cpp2IlInjected.Token(Token = "0x4000022")]
			public byte[] payload;
		}

		[Cpp2IlInjected.Token(Token = "0x4000020")]
		private static readonly JsonSerializerSettings EIVCLJILJGV;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9B808D0", Offset = "0x9B7F2D0", VA = "0x189B808D0")]
		public static EventWriter BROUQZGSWRF([In] this EventWriter evt, EPOORIVUAQX a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9B815D0", Offset = "0x9B7FFD0", VA = "0x189B815D0")]
		public static EventWriter MLKUFDKLBNK([In] this EventWriter evt, EPOORIVUAQX a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9B81C10", Offset = "0x9B80610", VA = "0x189B81C10")]
		public static string ZUDXJQVSABF(EPOORIVUAQX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9B819B0", Offset = "0x9B803B0", VA = "0x189B819B0")]
		public static string VTTTXJLHKLM(EPOORIVUAQX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9B80730", Offset = "0x9B7F130", VA = "0x189B80730")]
		public static string BETIYKMLKPG(EPOORIVUAQX a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9B81920", Offset = "0x9B80320", VA = "0x189B81920")]
		[CompilerGenerated]
		internal static bool VDBJOVBPKCQ([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9B81470", Offset = "0x9B7FE70", VA = "0x189B81470")]
		[CompilerGenerated]
		internal static bool CGNBLMJEFWJ([Out] string a, <>c__DisplayClass6_0 b)
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
