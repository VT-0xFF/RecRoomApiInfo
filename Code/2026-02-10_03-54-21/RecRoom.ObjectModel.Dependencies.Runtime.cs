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
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		[Cpp2IlInjected.Address(RVA = "0x85DE960", Offset = "0x85DDB60", VA = "0x1885DE960")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TGYWBCNCWWO
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
	[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
	public TGYWBCNCWWO()
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
		[Cpp2IlInjected.Address(RVA = "0x85DE860", Offset = "0x85DDA60", VA = "0x1885DE860", Slot = "4")]
		public override void JUFURAKXVZP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE0820", Offset = "0xADFA20", VA = "0x180AE0820")]
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
		private int[] ECEPPZWRAMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] ECJWNGQOJXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset ROOEZRYFVRR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset ROIYCLEIMGI;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] NNZFTIJYIXI;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xABE890", Offset = "0xABDA90", VA = "0x180ABE890", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1FC5840", Offset = "0x1FC4A40", VA = "0x181FC5840", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x85E2D20", Offset = "0x85E1F20", VA = "0x1885E2D20")]
		private void SZMWSWNXWRR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x85E2A20", Offset = "0x85E1C20", VA = "0x1885E2A20")]
		private void SZHPVPUANGI(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x85E2970", Offset = "0x85E1B70", VA = "0x1885E2970", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x85E30C0", Offset = "0x85E22C0", VA = "0x1885E30C0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(NETFKHHZDWR), new string[] { "Photon" })]
	public class IGSKGDJLKKE : NETFKHHZDWR
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class WCSXGBTRUJM : LRDLIWDIRTT
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public QVRCDNFGMQF KKEVHQWOZPS;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public ONGZNVPNXTX AAAJYIXSMAJ;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType OZSVPNIKROE
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x85E2830", Offset = "0x85E1A30", VA = "0x1885E2830", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId KXODMYZKDVX
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x85E2550", Offset = "0x85E1750", VA = "0x1885E2550", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool ZIVTZXSQOVE
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xB017C0", Offset = "0xB009C0", VA = "0x180B017C0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool YRMHONRCRCV
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x85E1F90", Offset = "0x85E1190", VA = "0x1885E1F90", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x85E2490", Offset = "0x85E1690", VA = "0x1885E2490", Slot = "9")]
			public bool LTHRSSWNSFA([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xABA410", Offset = "0xAB9610", VA = "0x180ABA410", Slot = "8")]
			public object HLFGNKEHHMM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x85E1E00", Offset = "0x85E1000", VA = "0x1885E1E00", Slot = "10")]
			private (PlayerId, object) HHMJFIKZURO()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x85E23A0", Offset = "0x85E15A0", VA = "0x1885E23A0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) LQFTIJWLAAU()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x85E1CD0", Offset = "0x85E0ED0", VA = "0x1885E1CD0", Slot = "12")]
			private DERKBPGAQTD<(ObjectNetworkId, PlayerId)> CNYXGMWSXTV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x85E2180", Offset = "0x85E1380", VA = "0x1885E2180", Slot = "13")]
			private (OutOfBandMessageType, byte[]) KUJEYHRZUUP()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x85E25A0", Offset = "0x85E17A0", VA = "0x1885E25A0", Slot = "14")]
			private (PacketSource, byte[]) QXYUNPRERNG()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C82DC0", Offset = "0x3C81FC0", VA = "0x183C82DC0", Slot = "15")]
			public a PSANDUQICYD<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x85E2880", Offset = "0x85E1A80", VA = "0x1885E2880", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public WCSXGBTRUJM()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class ONGZNVPNXTX : DERKBPGAQTD<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] GETYFVDIRVE;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int EMFZFZKJVBK
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x85DE9E0", Offset = "0x85DDBE0", VA = "0x1885DE9E0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x85DEA00", Offset = "0x85DDC00", VA = "0x1885DEA00", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public ONGZNVPNXTX()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x85DE750", Offset = "0x85DD950", VA = "0x1885DE750", Slot = "4")]
		public bool XLHEPGXBSHG(object a, LRDLIWDIRTT b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
		public IGSKGDJLKKE()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class CPLYUSJIJYX
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(OHRLHGJYLOY), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : HSMOOTIZJVU, VHRUAPZJZBY, OHRLHGJYLOY, QJSYQBVQVWT, FCSNFFOEHRZ
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log JXFMMOBINLM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private ZLFQBNXTTPY SERMBJTPEVP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private YYPEMZHFHUJ AHRMSMYHYFH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> THYKCTYUMXL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x85E0DE0", Offset = "0x85DFFE0", VA = "0x1885E0DE0", Slot = "4")]
		public void InitReferences(ANJPMPPNKBJ services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x85E1140", Offset = "0x85E0340", VA = "0x1885E1140", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x85E0BF0", Offset = "0x85DFDF0", VA = "0x1885E0BF0", Slot = "6")]
		public void HJFVLDJMVSL(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x85E0A70", Offset = "0x85DFC70", VA = "0x1885E0A70", Slot = "10")]
		public void FNOBXFOPPMY(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x85E0EC0", Offset = "0x85E00C0", VA = "0x1885E0EC0", Slot = "7")]
		public void NOIMFGNILKV(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x85E11E0", Offset = "0x85E03E0", VA = "0x1885E11E0")]
		private IDictionary<object, object> YBKVVBQUMBS(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x85E0A10", Offset = "0x85DFC10", VA = "0x1885E0A10")]
		public void BTECJRVKZKH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x85E10D0", Offset = "0x85E02D0", VA = "0x1885E10D0", Slot = "8")]
		private void SZIMTXAXYAT(ANJPMPPNKBJ a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xDD1810", Offset = "0xDD0A10", VA = "0x180DD1810", Slot = "9")]
		private void BZXKCYDOFXZ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x85E1580", Offset = "0x85E0780", VA = "0x1885E1580")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.TQGUSMFDDNV), new string[] { })]
	internal class TTDWRSUVQUS : JXTOAFBNMNK, RecRoom.RoomLoading.RoomOperation.TQGUSMFDDNV
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log ORHASIPKSKN;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] UJPSCRYHQFE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x85E18F0", Offset = "0x85E0AF0", VA = "0x1885E18F0")]
		public TTDWRSUVQUS()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class QTIQAYJVJKF : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x85E1600", Offset = "0x85E0800", VA = "0x1885E1600", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x85E17F0", Offset = "0x85E09F0", VA = "0x1885E17F0")]
		public QTIQAYJVJKF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class BPDLITHYQPE
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class DVLSPHLOUXJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings MYVOADNOZWV;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xABDFB0", Offset = "0xABD1B0", VA = "0x180ABDFB0")]
			public DVLSPHLOUXJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x85DE000", Offset = "0x85DD200", VA = "0x1885DE000")]
			internal string XYUKATINSYU(QVRCDNFGMQF a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x85DD7E0", Offset = "0x85DC9E0", VA = "0x1885DD7E0")]
		public static string GNTDTUWURWK(this QVRCDNFGMQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x85DDED0", Offset = "0x85DD0D0", VA = "0x1885DDED0")]
		public static NetworkEventType YDNPMIUZTTP(this QVRCDNFGMQF a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x85DD910", Offset = "0x85DCB10", VA = "0x1885DD910")]
		public static ViewId PHSGWFPISFK(this QVRCDNFGMQF a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x85DDE10", Offset = "0x85DD010", VA = "0x1885DDE10")]
		public static string QHJVFWVHVWS(this QVRCDNFGMQF a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x85DDD20", Offset = "0x85DCF20", VA = "0x1885DDD20")]
		private static string PZDSNKJEWAM(QVRCDNFGMQF a, Func<QVRCDNFGMQF, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x85DD690", Offset = "0x85DC890", VA = "0x1885DD690")]
		public static string DRXGQSXGZXG(this QVRCDNFGMQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x85DDB30", Offset = "0x85DCD30", VA = "0x1885DDB30")]
		public static ViewId PTAMGZMEINP(this QVRCDNFGMQF a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x85DD800", Offset = "0x85DCA00", VA = "0x1885DD800")]
		public static string OBPYWTWGCTF(this QVRCDNFGMQF a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FGLISUVYRTA
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class RCVNEBMUMPQ
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string LJFVYFOWVJT;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x85DE140", Offset = "0x85DD340", VA = "0x1885DE140")]
		public static string EURWRIZJVWR(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(PALSDSFHCIP), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class PALSDSFHCIP : JXTOAFBNMNK
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log BICYYRJFBRW;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log PYZRPBCIZJJ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log JLMSUGNQZAN;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] UJPSCRYHQFE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xABA440", Offset = "0xAB9640", VA = "0x180ABA440", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x85DECD0", Offset = "0x85DDED0", VA = "0x1885DECD0", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x85DEB60", Offset = "0x85DDD60", VA = "0x1885DEB60", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x85DEB50", Offset = "0x85DDD50", VA = "0x1885DEB50")]
		private void OLNZOJAIQSM(QVRCDNFGMQF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x85DEE40", Offset = "0x85DE040", VA = "0x1885DEE40")]
		private void RZVVHXNUAON(QVRCDNFGMQF a, QWRWUXWOZZA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x85DEE70", Offset = "0x85DE070", VA = "0x1885DEE70")]
		public void WRRETUMLRQH(QVRCDNFGMQF a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x85DEAA0", Offset = "0x85DDCA0", VA = "0x1885DEAA0")]
		private static Log EJEMJHJDRAJ(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x85DF130", Offset = "0x85DE330", VA = "0x1885DF130")]
		public PALSDSFHCIP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class PNRXMFIGDBQ
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
		private static readonly JsonSerializerSettings JYWUQGMCNTZ;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x85DF370", Offset = "0x85DE570", VA = "0x1885DF370")]
		public static EventWriter COPKLYPYWFT([In] this EventWriter evt, QVRCDNFGMQF a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x85E00E0", Offset = "0x85DF2E0", VA = "0x1885E00E0")]
		public static EventWriter PTHIXLTHAFY([In] this EventWriter evt, QVRCDNFGMQF a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x85E0420", Offset = "0x85DF620", VA = "0x1885E0420")]
		public static string SIKOUJFWFDX(QVRCDNFGMQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x85E0600", Offset = "0x85DF800", VA = "0x1885E0600")]
		public static string YIYXIUGTRLK(QVRCDNFGMQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x85DFF40", Offset = "0x85DF140", VA = "0x1885DFF40")]
		public static string ORSCCXCCPQO(QVRCDNFGMQF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x85DFEB0", Offset = "0x85DF0B0", VA = "0x1885DFEB0")]
		[CompilerGenerated]
		internal static bool OABRQUZEDIC([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x85DF210", Offset = "0x85DE410", VA = "0x1885DF210")]
		[CompilerGenerated]
		internal static bool BZOGSKGRDVR([Out] string a, <>c__DisplayClass6_0 b)
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
