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
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A1DE80", Offset = "0x9A1C880", VA = "0x189A1DE80")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class CWHGVYTHLWE
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
	[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
	public CWHGVYTHLWE()
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
		[Cpp2IlInjected.Address(RVA = "0x9A1DD80", Offset = "0x9A1C780", VA = "0x189A1DD80", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xCFFED0", Offset = "0xCFE8D0", VA = "0x180CFFED0")]
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
		private int[] YTBMQLWISIW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] YTGTNSQGBUF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset TSFXVIKPUMV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset TSAQYBQSLBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] JOPFBFLWYRO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xCD6C20", Offset = "0xCD5620", VA = "0x180CD6C20", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2234620", Offset = "0x2233020", VA = "0x182234620", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A21030", Offset = "0x9A1FA30", VA = "0x189A21030")]
		private void BAZLOGTATAR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A20D30", Offset = "0x9A1F730", VA = "0x189A20D30")]
		private void BAUEQZZDJPI(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A213E0", Offset = "0x9A1FDE0", VA = "0x189A213E0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A21490", Offset = "0x9A1FE90", VA = "0x189A21490")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(OATJEKIIPTB), new string[] { "Photon" })]
	public class ELXPIZZAEQO : OATJEKIIPTB
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class XAEUASVQKTG : HUHHCTUVUPJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public FAOJZRJMKFV VPXDINFDIJA;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public WPGTWRRZYAL ECLPTMBMUGH;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType UXYUOXCBTLU
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x9A20440", Offset = "0x9A1EE40", VA = "0x189A20440", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId YNXBKDDXBMX
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x9A20680", Offset = "0x9A1F080", VA = "0x189A20680", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool IGADIFNDMVC
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD20980", Offset = "0xD1F380", VA = "0x180D20980", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool DLWGNFCRNCD
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x9A209E0", Offset = "0x9A1F3E0", VA = "0x189A209E0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9A20490", Offset = "0x9A1EE90", VA = "0x189A20490", Slot = "9")]
			public bool LSQELRRDJMU([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCD6CD0", Offset = "0xCD56D0", VA = "0x180CD6CD0", Slot = "8")]
			public object JQAVZALKTWS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9A202B0", Offset = "0x9A1ECB0", VA = "0x189A202B0", Slot = "10")]
			private (PlayerId, object) GAXGJWKUYFI()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9A20BD0", Offset = "0x9A1F5D0", VA = "0x189A20BD0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) XUOVCBHDGRQ()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9A20550", Offset = "0x9A1EF50", VA = "0x189A20550", Slot = "12")]
			private OALTWBMPPFJ<(ObjectNetworkId, PlayerId)> ODIQUYLBFND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9A206D0", Offset = "0x9A1F0D0", VA = "0x189A206D0", Slot = "13")]
			private (OutOfBandMessageType, byte[]) STOFPMSJYON()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9A20020", Offset = "0x9A1EA20", VA = "0x189A20020", Slot = "14")]
			private (PacketSource, byte[]) ATWDAMKMUVQ()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x416B020", Offset = "0x4169A20", VA = "0x18416B020", Slot = "15")]
			public a IEXTXXQELIN<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9A208F0", Offset = "0x9A1F2F0", VA = "0x189A208F0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public XAEUASVQKTG()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class WPGTWRRZYAL : OALTWBMPPFJ<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] TMIISTRVIGQ;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int JEDXTOZKJHI
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x9A1FF60", Offset = "0x9A1E960", VA = "0x189A1FF60", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x9A1FF80", Offset = "0x9A1E980", VA = "0x189A1FF80", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public WPGTWRRZYAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BA60", Offset = "0x9A1A460", VA = "0x189A1BA60", Slot = "4")]
		public bool SYQOKEJVQMS(object a, HUHHCTUVUPJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
		public ELXPIZZAEQO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class TSOYTIXMKQV
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(PFFCSMZTFZY), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : HWCJESQYILK, QNWSCQURKKM, PFFCSMZTFZY, DYGRHSQNQBH, TQABOQMECSF
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log GLGEGNAUXIQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private NDLHZRTHZLO XBICCVOMZEX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private OZLCMQOKYPR XVZECNACEIL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> XRNBFAUUWQL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E8A0", Offset = "0x9A1D2A0", VA = "0x189A1E8A0", Slot = "4")]
		public void InitReferences(GEZRGCKOUXX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A1EC60", Offset = "0x9A1D660", VA = "0x189A1EC60", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E6B0", Offset = "0x9A1D0B0", VA = "0x189A1E6B0", Slot = "6")]
		public void HSTCVBXPHEF(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A1ED00", Offset = "0x9A1D700", VA = "0x189A1ED00", Slot = "10")]
		public void XFDNYNEEPVM(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E9E0", Offset = "0x9A1D3E0", VA = "0x189A1E9E0", Slot = "7")]
		public void LAKHSBYTACP(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A1EE80", Offset = "0x9A1D880", VA = "0x189A1EE80")]
		private IDictionary<object, object> ZHHOGHKQUMO(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E980", Offset = "0x9A1D380", VA = "0x189A1E980")]
		public void JQBTEKHXHIZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A1EBF0", Offset = "0x9A1D5F0", VA = "0x189A1EBF0", Slot = "8")]
		private void LJERCYKGCZL(GEZRGCKOUXX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1018B40", Offset = "0x1017540", VA = "0x181018B40", Slot = "9")]
		private void XGDIBOIJOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F230", Offset = "0x9A1DC30", VA = "0x189A1F230")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.SXPHOWRMZSB), new string[] { })]
	internal class CVIKECQHCHO : BLGDSMHUURE, RecRoom.RoomLoading.RoomOperation.SXPHOWRMZSB
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log DVXYLOAVTIP;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] SOWPMNVCDIE
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A1B9B0", Offset = "0x9A1A3B0", VA = "0x189A1B9B0")]
		public CVIKECQHCHO()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class IBJLYEBRWFZ : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BB70", Offset = "0x9A1A570", VA = "0x189A1BB70", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BD70", Offset = "0x9A1A770", VA = "0x189A1BD70")]
		public IBJLYEBRWFZ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class WESDRJLXXXK
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JZPSQTWWHKR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings JXUXGKCFBED;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xCDEAB0", Offset = "0xCDD4B0", VA = "0x180CDEAB0")]
			public JZPSQTWWHKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9A1D630", Offset = "0x9A1C030", VA = "0x189A1D630")]
			internal string APWSEAYQAGW(FAOJZRJMKFV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A1FE10", Offset = "0x9A1E810", VA = "0x189A1FE10")]
		public static string XFZZBWPSZRO(this FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A1FE30", Offset = "0x9A1E830", VA = "0x189A1FE30")]
		public static NetworkEventType YWRGFPMTQSD(this FAOJZRJMKFV a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F5E0", Offset = "0x9A1DFE0", VA = "0x189A1F5E0")]
		public static ViewId BBRVHMHDIYW(this FAOJZRJMKFV a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A1FB50", Offset = "0x9A1E550", VA = "0x189A1FB50")]
		public static string UTZXQCPUZIM(this FAOJZRJMKFV a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9A1FC10", Offset = "0x9A1E610", VA = "0x189A1FC10")]
		private static string VLMWRKSKJMG(FAOJZRJMKFV a, Func<FAOJZRJMKFV, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F800", Offset = "0x9A1E200", VA = "0x189A1F800")]
		public static string CZYCTZGCTWO(this FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A1F960", Offset = "0x9A1E360", VA = "0x189A1F960")]
		public static ViewId KKADCXCIAHZ(this FAOJZRJMKFV a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A1FD00", Offset = "0x9A1E700", VA = "0x189A1FD00")]
		public static string XFPXIRXCZLT(this FAOJZRJMKFV a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class LACXRXZCECE
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class ZZETAMDUBRG
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string WXJJPBCOZPF;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D770", Offset = "0x9A1C170", VA = "0x189A1D770")]
		public static string JQARYOXZMXF(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(OXKRRVKGLWN), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class OXKRRVKGLWN : BLGDSMHUURE
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log ABKSMDOTKYC;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log PZMXVEVGWEJ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log KAYTMFMWDDB;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] SOWPMNVCDIE
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xCDD350", Offset = "0xCDBD50", VA = "0x180CDD350", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E360", Offset = "0x9A1CD60", VA = "0x189A1E360", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E1E0", Offset = "0x9A1CBE0", VA = "0x189A1E1E0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A1DF00", Offset = "0x9A1C900", VA = "0x189A1DF00")]
		private void JCPEPACSOCO(FAOJZRJMKFV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E4E0", Offset = "0x9A1CEE0", VA = "0x189A1E4E0")]
		private void PTPZWLGERFB(FAOJZRJMKFV a, GTCQSIYUTCU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9A1DF10", Offset = "0x9A1C910", VA = "0x189A1DF10")]
		public void JODVXZHJEUZ(FAOJZRJMKFV a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E130", Offset = "0x9A1CB30", VA = "0x189A1E130")]
		private static Log OAKCSKZKZBR(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9A1E5C0", Offset = "0x9A1CFC0", VA = "0x189A1E5C0")]
		public OXKRRVKGLWN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class IZJTSYNJSJW
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
		private static readonly JsonSerializerSettings GZCUDLDINQR;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C330", Offset = "0x9A1AD30", VA = "0x189A1C330")]
		public static EventWriter XJJJLHWGTZZ([In] this EventWriter evt, FAOJZRJMKFV a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9A1D120", Offset = "0x9A1BB20", VA = "0x189A1D120")]
		public static EventWriter ZOACQUXGZRS([In] this EventWriter evt, FAOJZRJMKFV a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BDC0", Offset = "0x9A1A7C0", VA = "0x189A1BDC0")]
		public static string ALSFNVYBIUH(FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9A1CEC0", Offset = "0x9A1B8C0", VA = "0x189A1CEC0")]
		public static string YCAGRGKWFQO(FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C030", Offset = "0x9A1AA30", VA = "0x189A1C030")]
		public static string MGCDZWARYLO(FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A1BFA0", Offset = "0x9A1A9A0", VA = "0x189A1BFA0")]
		[CompilerGenerated]
		internal static bool DBLYTAOOLDC([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9A1C1D0", Offset = "0x9A1ABD0", VA = "0x189A1C1D0")]
		[CompilerGenerated]
		internal static bool QLDEQZPBSMZ([Out] string a, <>c__DisplayClass6_0 b)
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
