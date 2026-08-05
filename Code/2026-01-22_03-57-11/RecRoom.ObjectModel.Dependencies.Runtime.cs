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
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		[Cpp2IlInjected.Address(RVA = "0x84A8550", Offset = "0x84A6D50", VA = "0x1884A8550")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class ODSEWVGQSIN
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
	[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
	public ODSEWVGQSIN()
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
		[Cpp2IlInjected.Address(RVA = "0x84A8450", Offset = "0x84A6C50", VA = "0x1884A8450", Slot = "4")]
		public override void JPLRKQDWIBU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD7680", Offset = "0xAD5E80", VA = "0x180AD7680")]
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
		private int[] GGRLHWHSZPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] GGMEKPNVQEK;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset ERVRXHKVDYW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset ESAYUOESNKF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] TOPSDLGBOTX;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAACA80", Offset = "0xAAB280", VA = "0x180AACA80", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F61490", Offset = "0x1F5FC90", VA = "0x181F61490", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84AB510", Offset = "0x84A9D10", VA = "0x1884AB510")]
		private void LJCGTCDSEAS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84AB8B0", Offset = "0x84AA0B0", VA = "0x1884AB8B0")]
		private void LJHNQIXPNMB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84ABBC0", Offset = "0x84AA3C0", VA = "0x1884ABBC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84ABC70", Offset = "0x84AA470", VA = "0x1884ABC70")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(NJWZTXNUQBU), new string[] { "Photon" })]
	public class ZLNJVZDDFEB : NJWZTXNUQBU
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class RXVKQIIBVQF : LWQJHQOOUUU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public TZRHNFDOAHO TLUDKGFSHGR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public CNJHOCHRFLY DHEETGXHLAO;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType QWAVKIDXYXV
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x84A9B40", Offset = "0x84A8340", VA = "0x1884A9B40", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId CPHXQYQZLUC
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x84AA550", Offset = "0x84A8D50", VA = "0x1884AA550", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool WBXSMSXXAZD
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xAF7B10", Offset = "0xAF6310", VA = "0x180AF7B10", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool XVWYMRJDNYQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x84A9E30", Offset = "0x84A8630", VA = "0x1884A9E30", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84AA390", Offset = "0x84A8B90", VA = "0x1884AA390", Slot = "9")]
			public bool QMYMYEPKXIJ([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAACAC0", Offset = "0xAAB2C0", VA = "0x180AACAC0", Slot = "8")]
			public object LDJOUKNSZSR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x84AA5A0", Offset = "0x84A8DA0", VA = "0x1884AA5A0", Slot = "10")]
			private (PlayerId, object) ZRGDYPWLSFF()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x84AA730", Offset = "0x84A8F30", VA = "0x1884AA730", Slot = "11")]
			private (ObjectNetworkId, PlayerId) ZTYLUUEMNWP()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x84AA260", Offset = "0x84A8A60", VA = "0x1884AA260", Slot = "12")]
			private HMILMWOTIAS<(ObjectNetworkId, PlayerId)> PCSSRRTWORY()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x84AA030", Offset = "0x84A8830", VA = "0x1884AA030", Slot = "13")]
			private (OutOfBandMessageType, byte[]) LKEXPYDCRVA()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x84A9B90", Offset = "0x84A8390", VA = "0x1884A9B90", Slot = "14")]
			private (PacketSource, byte[]) IMRVQFEJSRP()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C61DC0", Offset = "0x3C605C0", VA = "0x183C61DC0", Slot = "15")]
			public a ICPAWPGMSFE<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x84AA460", Offset = "0x84A8C60", VA = "0x1884AA460", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public RXVKQIIBVQF()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class CNJHOCHRFLY : HMILMWOTIAS<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] FWPGSRARAYD;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int KGSUFPGCCQL
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x84A7FF0", Offset = "0x84A67F0", VA = "0x1884A7FF0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x84A8010", Offset = "0x84A6810", VA = "0x1884A8010", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public CNJHOCHRFLY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84AB400", Offset = "0x84A9C00", VA = "0x1884AB400", Slot = "4")]
		public bool OJCDRUUEASX(object a, LWQJHQOOUUU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
		public ZLNJVZDDFEB()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class IQPSVKSBSTQ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(TAZOYAKFVLB), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : NDLMBBFOQSV, KNSIDCCFBAF, TAZOYAKFVLB, WVKCUFPJZYK, KKGEYMKPCBE
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log WKLAFLLOLVN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private ENJSBFQGPIV AKEQLRUADZQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private ATPLYINLQMO QQWMGFNGFZM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> IRKIZRCTIPE;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x84A88B0", Offset = "0x84A70B0", VA = "0x1884A88B0", Slot = "4")]
		public void InitReferences(MZUBMRWQSAC services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84A9020", Offset = "0x84A7820", VA = "0x1884A9020", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84A8990", Offset = "0x84A7190", VA = "0x1884A8990", Slot = "6")]
		public void MMZMXTTHJKG(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84A8B80", Offset = "0x84A7380", VA = "0x1884A8B80", Slot = "10")]
		public void ONMWPVVCPFF(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84A85D0", Offset = "0x84A6DD0", VA = "0x1884A85D0", Slot = "7")]
		public void CKRYGIMZCOU(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84A8D00", Offset = "0x84A7500", VA = "0x1884A8D00")]
		private IDictionary<object, object> RTWNAOSXSQV(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84A8850", Offset = "0x84A7050", VA = "0x1884A8850")]
		public void FVOKMVSXNLI(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84A87E0", Offset = "0x84A6FE0", VA = "0x1884A87E0", Slot = "8")]
		private void DFEIFKWLVLC(MZUBMRWQSAC a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xDA6BD0", Offset = "0xDA53D0", VA = "0x180DA6BD0", Slot = "9")]
		private void WDBEGWLPSKA()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84A9140", Offset = "0x84A7940", VA = "0x1884A9140")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.YFXHVSZVRUQ), new string[] { })]
	internal class EMCHJTCZIWL : HXLCTATZPGH, RecRoom.RoomLoading.RoomOperation.YFXHVSZVRUQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log NYWDSRSMGVA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] QRAMDUWSVNV
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84A8340", Offset = "0x84A6B40", VA = "0x1884A8340")]
		public EMCHJTCZIWL()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class CVOPUHPEHOI : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x84A80B0", Offset = "0x84A68B0", VA = "0x1884A80B0", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84A82A0", Offset = "0x84A6AA0", VA = "0x1884A82A0")]
		public CVOPUHPEHOI()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class QKGXILBXMAZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class TSTXUAFEGEM
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings HFDOWUVTIWE;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAB5950", Offset = "0xAB4150", VA = "0x180AB5950")]
			public TSTXUAFEGEM()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84AA820", Offset = "0x84A9020", VA = "0x1884AA820")]
			internal string PTOKSCIGMLV(TZRHNFDOAHO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84A9420", Offset = "0x84A7C20", VA = "0x1884A9420")]
		public static string JIBQLJEFJPB(this TZRHNFDOAHO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84A9A00", Offset = "0x84A8200", VA = "0x1884A9A00")]
		public static NetworkEventType SRBKVDBHDKY(this TZRHNFDOAHO a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84A9440", Offset = "0x84A7C40", VA = "0x1884A9440")]
		public static ViewId NMBEQVVUEQD(this TZRHNFDOAHO a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84A9940", Offset = "0x84A8140", VA = "0x1884A9940")]
		public static string SGZDJVCOBJT(this TZRHNFDOAHO a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84A9850", Offset = "0x84A8050", VA = "0x1884A9850")]
		private static string OTXYPMIIUVJ(TZRHNFDOAHO a, Func<TZRHNFDOAHO, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84A92D0", Offset = "0x84A7AD0", VA = "0x1884A92D0")]
		public static string CRCDQJCFLMV(this TZRHNFDOAHO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84A9660", Offset = "0x84A7E60", VA = "0x1884A9660")]
		public static ViewId NUSPTMMGMSC(this TZRHNFDOAHO a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84A91C0", Offset = "0x84A79C0", VA = "0x1884A91C0")]
		public static string BLFKNBJQBJQ(this TZRHNFDOAHO a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class BPXLXDZVLMD
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class KNUNXQEBDMX
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string KQMOFRDRBWC;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84A79E0", Offset = "0x84A61E0", VA = "0x1884A79E0")]
		public static string WUKYVEILWYU(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(YOPUAYANMCY), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class YOPUAYANMCY : HXLCTATZPGH
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log YMEKHRSOVQT;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log AXBYQCNOXAM;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log HLJYZYDWJCS;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] QRAMDUWSVNV
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAB1210", Offset = "0xAAFA10", VA = "0x180AB1210", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84AB060", Offset = "0x84A9860", VA = "0x1884AB060", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84AAEF0", Offset = "0x84A96F0", VA = "0x1884AAEF0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84AAC90", Offset = "0x84A9490", VA = "0x1884AAC90")]
		private void CUMAOEPULHH(TZRHNFDOAHO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84AACA0", Offset = "0x84A94A0", VA = "0x1884AACA0")]
		private void IBVTTIIIIZW(TZRHNFDOAHO a, JFVSBLTWLJF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84AACD0", Offset = "0x84A94D0", VA = "0x1884AACD0")]
		public void NURLROXONIM(TZRHNFDOAHO a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84AB1D0", Offset = "0x84A99D0", VA = "0x1884AB1D0")]
		private static Log RGZMHEFDUHO(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84AB320", Offset = "0x84A9B20", VA = "0x1884AB320")]
		public YOPUAYANMCY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class BJPKIJKXNED
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
		private static readonly JsonSerializerSettings LBERODVPIBA;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x84A65B0", Offset = "0x84A4DB0", VA = "0x1884A65B0")]
		public static EventWriter JOMCRUOYKNG([In] this EventWriter evt, TZRHNFDOAHO a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84A6260", Offset = "0x84A4A60", VA = "0x1884A6260")]
		public static EventWriter HLKWZSHWWQL([In] this EventWriter evt, TZRHNFDOAHO a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84A7350", Offset = "0x84A5B50", VA = "0x1884A7350")]
		public static string UHXMXYASVJW(TZRHNFDOAHO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84A70F0", Offset = "0x84A58F0", VA = "0x1884A70F0")]
		public static string SSZHQBXMMTB(TZRHNFDOAHO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84A7530", Offset = "0x84A5D30", VA = "0x1884A7530")]
		public static string XGPAPEEZAUT(TZRHNFDOAHO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84A61D0", Offset = "0x84A49D0", VA = "0x1884A61D0")]
		[CompilerGenerated]
		internal static bool DLJPIHEASUD([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84A76D0", Offset = "0x84A5ED0", VA = "0x1884A76D0")]
		[CompilerGenerated]
		internal static bool XRVYZHNEFCW([Out] string a, <>c__DisplayClass6_0 b)
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
