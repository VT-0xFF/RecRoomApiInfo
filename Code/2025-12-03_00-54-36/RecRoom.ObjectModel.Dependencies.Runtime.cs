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
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		[Cpp2IlInjected.Address(RVA = "0x83782F0", Offset = "0x8376EF0", VA = "0x1883782F0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class OPFYJNMMZGZ
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
	[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
	public OPFYJNMMZGZ()
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
		[Cpp2IlInjected.Address(RVA = "0x83780E0", Offset = "0x8376CE0", VA = "0x1883780E0", Slot = "4")]
		public override void OGBNJYRINGK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xABFE50", Offset = "0xABEA50", VA = "0x180ABFE50")]
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
		private int[] RXQWJMLBFSB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] RXLPMFRDWGS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset DXAPYCEYZZY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset DXFWVIYWJLH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] PSHMPKINIMB;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xA98620", Offset = "0xA97220", VA = "0x180A98620", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1EE26B0", Offset = "0x1EE12B0", VA = "0x181EE26B0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x837C570", Offset = "0x837B170", VA = "0x18837C570")]
		private void JGBTHBSKOEG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x837C920", Offset = "0x837B520", VA = "0x18837C920")]
		private void JGHAEIMHXPP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x837CC30", Offset = "0x837B830", VA = "0x18837CC30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x837CCE0", Offset = "0x837B8E0", VA = "0x18837CCE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(ACJHXTOTIDU), new string[] { "Photon" })]
	public class MLBRUDASKSN : ACJHXTOTIDU
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class LOENXJINQDH : TAHYMDNNGIQ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public PKPJICLPGZO OBZFKXLMQYF;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public OHQUQLYQNVY ZXFCTGMLWRE;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType XSYNALKQIRF
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x8378040", Offset = "0x8376C40", VA = "0x188378040", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId FKLZNFVZBGS
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x8378090", Offset = "0x8376C90", VA = "0x188378090", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool PCZBENFWRMF
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xAE0370", Offset = "0xADEF70", VA = "0x180AE0370", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool HLHUCEWMJPO
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x8377C80", Offset = "0x8376880", VA = "0x188377C80", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8377F70", Offset = "0x8376B70", VA = "0x188377F70", Slot = "9")]
			public bool XLNVCSWLVLH([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xA974F0", Offset = "0xA960F0", VA = "0x180A974F0", Slot = "8")]
			public object NMFLUMCWAFT()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8377AF0", Offset = "0x83766F0", VA = "0x188377AF0", Slot = "10")]
			private (PlayerId, object) OKPDILAMABJ()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83778D0", Offset = "0x83764D0", VA = "0x1883778D0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) KQKMZKYYMQL()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x83779C0", Offset = "0x83765C0", VA = "0x1883779C0", Slot = "12")]
			private RTMFWZOIEIO<(ObjectNetworkId, PlayerId)> MNDTFCTLTRA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8377400", Offset = "0x8376000", VA = "0x188377400", Slot = "13")]
			private (OutOfBandMessageType, byte[]) JJZWLXTOZUG()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8377630", Offset = "0x8376230", VA = "0x188377630", Slot = "14")]
			private (PacketSource, byte[]) KECSTSIVKAF()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C252B0", Offset = "0x3C23EB0", VA = "0x183C252B0", Slot = "15")]
			public a NRBCXYYNXEO<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8377E80", Offset = "0x8376A80", VA = "0x188377E80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public LOENXJINQDH()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class OHQUQLYQNVY : RTMFWZOIEIO<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] OCSMZTGZLFJ;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int EYPZHMQDKRN
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x8378370", Offset = "0x8376F70", VA = "0x188378370", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x8378390", Offset = "0x8376F90", VA = "0x188378390", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public OHQUQLYQNVY()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83781E0", Offset = "0x8376DE0", VA = "0x1883781E0", Slot = "4")]
		public bool LMMIVTGGNIT(object a, TAHYMDNNGIQ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
		public MLBRUDASKSN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class APKIMTRBDPI
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(LOWJFSDSAVV), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : KWODXIHZOSZ, DXKVHEDTUEV, LOWJFSDSAVV, IQIQMYLKLGS, GWUWQZCMFZU
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log JVTVAZRWBFB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private PVOPMBCILPD OKLMDKLKPBM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private WHYFEJKXKBY BXCDRGPHVUS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> QEYKKRAJJJI;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83786F0", Offset = "0x83772F0", VA = "0x1883786F0", Slot = "4")]
		public void InitReferences(FRTNUJPZGKS services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x8378D00", Offset = "0x8377900", VA = "0x188378D00", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8378430", Offset = "0x8377030", VA = "0x188378430", Slot = "6")]
		public void DHOUHFSFWJA(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8378DA0", Offset = "0x83779A0", VA = "0x188378DA0", Slot = "10")]
		public void TSANEKHRVDN(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83787D0", Offset = "0x83773D0", VA = "0x1883787D0", Slot = "7")]
		public void LGTVKQYPTMA(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83789E0", Offset = "0x83775E0", VA = "0x1883789E0")]
		private IDictionary<object, object> PDDGUSKEVIV(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8378690", Offset = "0x8377290", VA = "0x188378690")]
		public void EDMPWAKMPSO(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8378620", Offset = "0x8377220", VA = "0x188378620", Slot = "8")]
		private void ECGVZCYOEDK(FRTNUJPZGKS a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD19560", Offset = "0xD18160", VA = "0x180D19560", Slot = "9")]
		private void RXSKOFHNRCQ()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8378FB0", Offset = "0x8377BB0", VA = "0x188378FB0")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.NLUQMHKDKCM), new string[] { })]
	internal class UZDDZRQBRBN : AEUXGJHXGFZ, RecRoom.RoomLoading.RoomOperation.NLUQMHKDKCM
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log CFJKNYAYWPY;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] CWRHNDASEBF
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83799C0", Offset = "0x83785C0", VA = "0x1883799C0")]
		public UZDDZRQBRBN()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class JKNYICIGWNK : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83771B0", Offset = "0x8375DB0", VA = "0x1883771B0", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83773B0", Offset = "0x8375FB0", VA = "0x1883773B0")]
		public JKNYICIGWNK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class WRIHPGBRLHL
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class VVHTIKYAJVS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings AXXYMMNATJG;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xA9C6D0", Offset = "0xA9B2D0", VA = "0x180A9C6D0")]
			public VVHTIKYAJVS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8379A70", Offset = "0x8378670", VA = "0x188379A70")]
			internal string UVMOOUNBVRZ(PKPJICLPGZO a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x837B800", Offset = "0x837A400", VA = "0x18837B800")]
		public static string TAGVPUQURXV(this PKPJICLPGZO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x837BC80", Offset = "0x837A880", VA = "0x18837BC80")]
		public static NetworkEventType XKJMKHYXHDS(this PKPJICLPGZO a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x837B520", Offset = "0x837A120", VA = "0x18837B520")]
		public static ViewId HMCCNNGKEXB(this PKPJICLPGZO a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x837B740", Offset = "0x837A340", VA = "0x18837B740")]
		public static string NWOQWRFQPTD(this PKPJICLPGZO a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x837B430", Offset = "0x837A030", VA = "0x18837B430")]
		private static string FRTBCPCKUPJ(PKPJICLPGZO a, Func<PKPJICLPGZO, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x837B820", Offset = "0x837A420", VA = "0x18837B820")]
		public static string UYSNFLUNYEN(this PKPJICLPGZO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x837B980", Offset = "0x837A580", VA = "0x18837B980")]
		public static ViewId WWULBSPXXOK(this PKPJICLPGZO a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x837BB70", Offset = "0x837A770", VA = "0x18837BB70")]
		public static string XBJUKXBFNXY(this PKPJICLPGZO a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class QCHPSFYPDIP
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class GZCJVSLHBWH
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string HEZGGVLZQMW;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x8379030", Offset = "0x8377C30", VA = "0x188379030")]
		public static string FCGRUACCBYM(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(XLIYQWCCRKY), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class XLIYQWCCRKY : AEUXGJHXGFZ
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log FSECOLZJEWX;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log HYFHKQKUNUI;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log NTBVXMOVDZI;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] CWRHNDASEBF
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xA9FED0", Offset = "0xA9EAD0", VA = "0x180A9FED0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x837C170", Offset = "0x837AD70", VA = "0x18837C170", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x837BFF0", Offset = "0x837ABF0", VA = "0x18837BFF0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x837BFE0", Offset = "0x837ABE0", VA = "0x18837BFE0")]
		private void GJVQBNBTNDT(PKPJICLPGZO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x837C3A0", Offset = "0x837AFA0", VA = "0x18837C3A0")]
		private void VJDKVQLGQHO(PKPJICLPGZO a, QINZOSCQMJF b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x837BDC0", Offset = "0x837A9C0", VA = "0x18837BDC0")]
		public void FUAWOYPKILW(PKPJICLPGZO a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x837C2F0", Offset = "0x837AEF0", VA = "0x18837C2F0")]
		private static Log RWNSZPUVRZC(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x837C480", Offset = "0x837B080", VA = "0x18837C480")]
		public XLIYQWCCRKY()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class WKOJUNVERTJ
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
		private static readonly JsonSerializerSettings TJUGHXXJLMS;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x837A310", Offset = "0x8378F10", VA = "0x18837A310")]
		public static EventWriter QMMAGQDYNLC([In] this EventWriter evt, PKPJICLPGZO a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x8379BB0", Offset = "0x83787B0", VA = "0x188379BB0")]
		public static EventWriter FSNNJIEIMDR([In] this EventWriter evt, PKPJICLPGZO a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x8379F90", Offset = "0x8378B90", VA = "0x188379F90")]
		public static string JEFBLGVEMVG(PKPJICLPGZO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x837B010", Offset = "0x8379C10", VA = "0x18837B010")]
		public static string VERZZZNOKMT(PKPJICLPGZO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x837A170", Offset = "0x8378D70", VA = "0x18837A170")]
		public static string NSIEEKNXXLF(PKPJICLPGZO a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x8379F00", Offset = "0x8378B00", VA = "0x188379F00")]
		[CompilerGenerated]
		internal static bool FYXACFVOEAP([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x837AEB0", Offset = "0x8379AB0", VA = "0x18837AEB0")]
		[CompilerGenerated]
		internal static bool SLRVQZXYUJY([Out] string a, <>c__DisplayClass6_0 b)
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
