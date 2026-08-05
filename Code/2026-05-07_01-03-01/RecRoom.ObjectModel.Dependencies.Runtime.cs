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
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		[Cpp2IlInjected.Address(RVA = "0x99F5820", Offset = "0x99F4220", VA = "0x1899F5820")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TMRYTQGXOHE
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
	[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
	public TMRYTQGXOHE()
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
		[Cpp2IlInjected.Address(RVA = "0x99F5720", Offset = "0x99F4120", VA = "0x1899F5720", Slot = "4")]
		public override void QCIVJGOFOSZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCFAE40", Offset = "0xCF9840", VA = "0x180CFAE40")]
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
		private int[] QBWAEFIMHOM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] QCBHBMCJQZV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset GKXUUHBMTQD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset GKSNXAHPKEU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] GELRCXWPEUG;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCDB330", Offset = "0xCD9D30", VA = "0x180CDB330", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x222F660", Offset = "0x222E060", VA = "0x18222F660", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x99F9DE0", Offset = "0x99F87E0", VA = "0x1899F9DE0")]
		private void QLHWPSDGGQL(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x99F9AE0", Offset = "0x99F84E0", VA = "0x1899F9AE0")]
		private void QLCPSLJIXFC(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x99FA190", Offset = "0x99F8B90", VA = "0x1899FA190", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x99FA240", Offset = "0x99F8C40", VA = "0x1899FA240")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(NCYMHFNRNPX), new string[] { "Photon" })]
	public class RWLLITDBMGM : NCYMHFNRNPX
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class IUYSYKKWWGS : LSHBYQPFVGF
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public VZZVUJOFUEN KPARYWYMLNG;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public LAVGOFMADOZ ZYZJQGCZQXT;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType MERZPCICCKQ
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x99F4CD0", Offset = "0x99F36D0", VA = "0x1899F4CD0", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId TNCIAZFLYKB
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x99F49C0", Offset = "0x99F33C0", VA = "0x1899F49C0", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool ACPGONEGDUC
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD1B850", Offset = "0xD1A250", VA = "0x180D1B850", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool KVSLNMNWHQJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x99F5470", Offset = "0x99F3E70", VA = "0x1899F5470", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x99F53B0", Offset = "0x99F3DB0", VA = "0x1899F53B0", Slot = "9")]
			public bool UKMBSGZMALM([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CC0", Offset = "0xCD26C0", VA = "0x180CD3CC0", Slot = "8")]
			public object HMWJLIQFSIQ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x99F4B40", Offset = "0x99F3540", VA = "0x1899F4B40", Slot = "10")]
			private (PlayerId, object) ITYQGXMBHSA()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x99F51D0", Offset = "0x99F3BD0", VA = "0x1899F51D0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) SWNSKSVUSBC()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x99F4A10", Offset = "0x99F3410", VA = "0x1899F4A10", Slot = "12")]
			private AAQAIJYTKPD<(ObjectNetworkId, PlayerId)> FZQPGFPQYLJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x99F4D20", Offset = "0x99F3720", VA = "0x1899F4D20", Slot = "13")]
			private (OutOfBandMessageType, byte[]) PEOPISDBLCP()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x99F4F40", Offset = "0x99F3940", VA = "0x1899F4F40", Slot = "14")]
			private (PacketSource, byte[]) QGARVGDBOXO()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x413F4F0", Offset = "0x413DEF0", VA = "0x18413F4F0", Slot = "15")]
			public a HUOGTGQXMFZ<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x99F52C0", Offset = "0x99F3CC0", VA = "0x1899F52C0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public IUYSYKKWWGS()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class LAVGOFMADOZ : AAQAIJYTKPD<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] MDXOHSKQNAO;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int FUKZCZVBGQY
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x99F5660", Offset = "0x99F4060", VA = "0x1899F5660", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x99F5680", Offset = "0x99F4080", VA = "0x1899F5680", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public LAVGOFMADOZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99F7D10", Offset = "0x99F6710", VA = "0x1899F7D10", Slot = "4")]
		public bool CDBQJAFJOGY(object a, LSHBYQPFVGF b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
		public RWLLITDBMGM()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class ZCRXRADPEET
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(IUHAKADKMGM), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : ZVXNWENCXPY, ITCNKCLUYXA, IUHAKADKMGM, DWYARZFXYRJ, MJCONUSWWSL
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log OMWAZFACTUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private UBEZRPBXLGK MSCWXNUUOPT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private OVXPTUNEMUV AMPHUDNPUZX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> IUXNUTJVHZL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x99F5910", Offset = "0x99F4310", VA = "0x1899F5910", Slot = "4")]
		public void InitReferences(GZOGVDISCYD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x99F5BD0", Offset = "0x99F45D0", VA = "0x1899F5BD0", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x99F5E80", Offset = "0x99F4880", VA = "0x1899F5E80", Slot = "6")]
		public void UMZYUASZGCH(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x99F59F0", Offset = "0x99F43F0", VA = "0x1899F59F0", Slot = "10")]
		public void KNKZRUAUNKU(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x99F5C70", Offset = "0x99F4670", VA = "0x1899F5C70", Slot = "7")]
		public void UKSCXPWICFD(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x99F6070", Offset = "0x99F4A70", VA = "0x1899F6070")]
		private IDictionary<object, object> URVYRQIWXOM(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x99F5B70", Offset = "0x99F4570", VA = "0x1899F5B70")]
		public void NQNFUQKKGRF(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x99F58A0", Offset = "0x99F42A0", VA = "0x1899F58A0", Slot = "8")]
		private void EZUYJSDOFYP(GZOGVDISCYD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1013D00", Offset = "0x1012700", VA = "0x181013D00", Slot = "9")]
		private void YIQUJNZVLKD()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x99F6420", Offset = "0x99F4E20", VA = "0x1899F6420")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.HQWQMHBBLGD), new string[] { })]
	internal class GVZDGCEVSIK : QMIUMBGTXFG, RecRoom.RoomLoading.RoomOperation.HQWQMHBBLGD
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log MSDJJWFXJYV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] GUBMDYZSYCS
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x99F4910", Offset = "0x99F3310", VA = "0x1899F4910")]
		public GVZDGCEVSIK()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class TOMMHBWSZXD : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x99F7E20", Offset = "0x99F6820", VA = "0x1899F7E20", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99F8020", Offset = "0x99F6A20", VA = "0x1899F8020")]
		public TOMMHBWSZXD()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class YWKNQZUJUUS
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class FBYKUNLQLDN
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings EBELQGJZEAF;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCD7590", Offset = "0xCD5F90", VA = "0x180CD7590")]
			public FBYKUNLQLDN()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x99F4780", Offset = "0x99F3180", VA = "0x1899F4780")]
			internal string TXBNMMBRVBW(VZZVUJOFUEN a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x99F9160", Offset = "0x99F7B60", VA = "0x1899F9160")]
		public static string BFZFQXIHWRI(this VZZVUJOFUEN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x99F9790", Offset = "0x99F8190", VA = "0x1899F9790")]
		public static NetworkEventType PECELIWJFGB(this VZZVUJOFUEN a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x99F9180", Offset = "0x99F7B80", VA = "0x1899F9180")]
		public static ViewId EXBKFOUZBPK(this VZZVUJOFUEN a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x99F9A20", Offset = "0x99F8420", VA = "0x1899F9A20")]
		public static string UDBNYDIKBHI(this VZZVUJOFUEN a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x99F96A0", Offset = "0x99F80A0", VA = "0x1899F96A0")]
		private static string LQELWXAZVCM(VZZVUJOFUEN a, Func<VZZVUJOFUEN, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x99F98C0", Offset = "0x99F82C0", VA = "0x1899F98C0")]
		public static string TMHLECXWSEI(this VZZVUJOFUEN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x99F93A0", Offset = "0x99F7DA0", VA = "0x1899F93A0")]
		public static ViewId KMSZENLHFIN(this VZZVUJOFUEN a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x99F9590", Offset = "0x99F7F90", VA = "0x1899F9590")]
		public static string LABKWEPKLLZ(this VZZVUJOFUEN a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class UQIXUCRHUHM
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class BVLUFCRVTXE
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string DLCLDTZXVDP;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x99F83A0", Offset = "0x99F6DA0", VA = "0x1899F83A0")]
		public static string IUUFHTJLGBX(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(VXPHDUCDMPJ), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class VXPHDUCDMPJ : QMIUMBGTXFG
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log QYGVLJVDIYM;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log GVNZFKABILJ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log YVECQQMVQIB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] GUBMDYZSYCS
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCD3CB0", Offset = "0xCD26B0", VA = "0x180CD3CB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x99F8C10", Offset = "0x99F7610", VA = "0x1899F8C10", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x99F8A90", Offset = "0x99F7490", VA = "0x1899F8A90", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x99F8D90", Offset = "0x99F7790", VA = "0x1899F8D90")]
		private void PRNEQBDRQEI(VZZVUJOFUEN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x99F89B0", Offset = "0x99F73B0", VA = "0x1899F89B0")]
		private void JKCTHMSDGRH(VZZVUJOFUEN a, BJJNNDTQGRE b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x99F8DA0", Offset = "0x99F77A0", VA = "0x1899F8DA0")]
		public void VBSUFCVUMUT(VZZVUJOFUEN a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x99F89E0", Offset = "0x99F73E0", VA = "0x1899F89E0")]
		private static Log MYIVZYJRMWZ(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x99F9070", Offset = "0x99F7A70", VA = "0x1899F9070")]
		public VXPHDUCDMPJ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class RDMCAPCQGPA
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
		private static readonly JsonSerializerSettings IPQEJPHPLMX;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x99F6BC0", Offset = "0x99F55C0", VA = "0x1899F6BC0")]
		public static EventWriter UQCVKPZTBVX([In] this EventWriter evt, VZZVUJOFUEN a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x99F6870", Offset = "0x99F5270", VA = "0x1899F6870")]
		public static EventWriter ONTVEAHWBHQ([In] this EventWriter evt, VZZVUJOFUEN a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x99F6690", Offset = "0x99F5090", VA = "0x1899F6690")]
		public static string NVGFNXHMCAJ(VZZVUJOFUEN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x99F7750", Offset = "0x99F6150", VA = "0x1899F7750")]
		public static string XODZGIUIVZO(VZZVUJOFUEN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x99F79B0", Offset = "0x99F63B0", VA = "0x1899F79B0")]
		public static string ZCALPORKRHY(VZZVUJOFUEN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x99F6600", Offset = "0x99F5000", VA = "0x1899F6600")]
		[CompilerGenerated]
		internal static bool MEXEQKENPTE([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x99F64A0", Offset = "0x99F4EA0", VA = "0x1899F64A0")]
		[CompilerGenerated]
		internal static bool IMWKVWGKSMP([Out] string a, <>c__DisplayClass6_0 b)
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
