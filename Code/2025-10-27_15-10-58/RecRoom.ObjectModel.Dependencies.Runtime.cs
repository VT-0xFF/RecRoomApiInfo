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
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x88DBF20", Offset = "0x88DAF20", VA = "0x1888DBF20")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class MZHUOFNWOZJ
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
	[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
	public MZHUOFNWOZJ()
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
		[Cpp2IlInjected.Address(RVA = "0x88DBD60", Offset = "0x88DAD60", VA = "0x1888DBD60", Slot = "4")]
		public override void YTBQRMTMKZK()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAF86F0", Offset = "0xAF76F0", VA = "0x180AF86F0")]
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
		private int[] LHVPIFQWCCH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] LHQIKYWYSQY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset EVWCTMNURRO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset EWBJQTHSBCX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] IQRGEULHSFZ;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xACFF60", Offset = "0xACEF60", VA = "0x180ACFF60", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x24AA5C0", Offset = "0x24A95C0", VA = "0x1824AA5C0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x88DFEB0", Offset = "0x88DEEB0", VA = "0x1888DFEB0")]
		private void SSAHAHAUBXG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x88E0260", Offset = "0x88DF260", VA = "0x1888E0260")]
		private void SSFNXNURLIP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x88DFE00", Offset = "0x88DEE00", VA = "0x1888DFE00", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x88E0560", Offset = "0x88DF560", VA = "0x1888E0560")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(BPZPLCVMGOI), new string[] { "Photon" })]
	public class YCULCGPUCTR : BPZPLCVMGOI
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class VLXPYZDTNZV : UGWSUCXAOVA
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public IRRSNCQWIPE UUFWEWJTTBV;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public StatusCode QCNKEEGLCES;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public NMWZPMBRFEE YYJFUTLELHG;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType OVCFCLRZRCZ
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x88DD260", Offset = "0x88DC260", VA = "0x1888DD260", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId YXEDWVJZCOE
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x88DDE80", Offset = "0x88DCE80", VA = "0x1888DDE80", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool KUOKEDYUGLR
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x88DDED0", Offset = "0x88DCED0", VA = "0x1888DDED0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool PPAEMYIFLKW
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x88DD2B0", Offset = "0x88DC2B0", VA = "0x1888DD2B0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x88DDB40", Offset = "0x88DCB40", VA = "0x1888DDB40", Slot = "9")]
			public bool PYLDXFOVODR([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x88DDC10", Offset = "0x88DCC10", VA = "0x1888DDC10", Slot = "8")]
			public object RCOQCOCDLSP()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x88DD780", Offset = "0x88DC780", VA = "0x1888DD780", Slot = "10")]
			private (PlayerId, object) NZHXWIDMMOZ()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x88DD690", Offset = "0x88DC690", VA = "0x1888DD690", Slot = "11")]
			private (ObjectNetworkId, PlayerId) FBBKMCHTKDT()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x88DDC60", Offset = "0x88DCC60", VA = "0x1888DDC60", Slot = "12")]
			private GPACHAAZRTK<(ObjectNetworkId, PlayerId)> SYNOIEUGHCA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x88DD910", Offset = "0x88DC910", VA = "0x1888DD910", Slot = "13")]
			private (OutOfBandMessageType, byte[]) PYKTPCAKFHS()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x88DD470", Offset = "0x88DC470", VA = "0x1888DD470", Slot = "14")]
			private (PacketSource, byte[]) EPHLTELKSGP()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3FAC910", Offset = "0x3FAB910", VA = "0x183FAC910", Slot = "15")]
			public a EAVRJMEVYSM<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x88DDD90", Offset = "0x88DCD90", VA = "0x1888DDD90", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public VLXPYZDTNZV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class NMWZPMBRFEE : GPACHAAZRTK<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int[] OQEKLIOEGGV;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int YUAPMLUENDX
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x88DBE60", Offset = "0x88DAE60", VA = "0x1888DBE60", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x88DBE80", Offset = "0x88DAE80", VA = "0x1888DBE80", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public NMWZPMBRFEE()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x88DDEE0", Offset = "0x88DCEE0", VA = "0x1888DDEE0", Slot = "4")]
		public bool RTJDIESGOFD(object a, UGWSUCXAOVA b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
		public YCULCGPUCTR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class UGFAZILZDOU
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(FRWSYXSERFP), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : GLEZUUFUFAX, GRBARKQDGSD, FRWSYXSERFP, OYGFOCCYTLG, LTOXHYHZXEQ
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Log BMHSVNOOAKJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private ZMJFNHLELSL WGPDOGRACKA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[DependsOn]
		private WSMSRSDVIDW NWCZCEDJTKQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Hashtable SUOKTEDTNOA;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x88DC190", Offset = "0x88DB190", VA = "0x1888DC190", Slot = "4")]
		public void InitReferences(GQPULEKOHTO services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x88DC400", Offset = "0x88DB400", VA = "0x1888DC400", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x88DC6F0", Offset = "0x88DB6F0", VA = "0x1888DC6F0", Slot = "6")]
		public void ZTLUZTAJCRW(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x88DC270", Offset = "0x88DB270", VA = "0x1888DC270", Slot = "10")]
		public void NOQCQVVDGVL(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x88DC000", Offset = "0x88DB000", VA = "0x1888DC000", Slot = "7")]
		public void IPYONDQKLWC(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x88DC4A0", Offset = "0x88DB4A0", VA = "0x1888DC4A0")]
		private Hashtable VCSUZUNMRNF(Hashtable a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x88DBFA0", Offset = "0x88DAFA0", VA = "0x1888DBFA0")]
		public void CHFLYAHFGTG(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x88DC390", Offset = "0x88DB390", VA = "0x1888DC390", Slot = "8")]
		private void SMUSGLXJIVI(GQPULEKOHTO a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x10EE0F0", Offset = "0x10ED0F0", VA = "0x1810EE0F0", Slot = "9")]
		private void CXZMGJMBDJU()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x88DC8E0", Offset = "0x88DB8E0", VA = "0x1888DC8E0")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.SZONQHVVCJM), new string[] { })]
	internal class EECWHHBZXEZ : LXIVYDCSTEJ, RecRoom.RoomLoading.RoomOperation.SZONQHVVCJM
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log TTNAVZDPMIA;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] NUYYDGYOCRP
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x88DB9F0", Offset = "0x88DA9F0", VA = "0x1888DB9F0")]
		public EECWHHBZXEZ()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class FKIJOVPOZGC : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x88DBB10", Offset = "0x88DAB10", VA = "0x1888DBB10", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x88DBD10", Offset = "0x88DAD10", VA = "0x1888DBD10")]
		public FKIJOVPOZGC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class CWYGBIRPHQL
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class CWRWNJLXLSS
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public JsonSerializerSettings ZZUXVVETJKG;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAD4DA0", Offset = "0xAD3DA0", VA = "0x180AD4DA0")]
			public CWRWNJLXLSS()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x88DAF30", Offset = "0x88D9F30", VA = "0x1888DAF30")]
			internal string VKZQFQGCQMV(IRRSNCQWIPE a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x88DB460", Offset = "0x88DA460", VA = "0x1888DB460")]
		public static string QFITCNASXUV(this IRRSNCQWIPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x88DB480", Offset = "0x88DA480", VA = "0x1888DB480")]
		public static NetworkEventType QHGMZNCCNMG(this IRRSNCQWIPE a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x88DB070", Offset = "0x88DA070", VA = "0x1888DB070")]
		public static ViewId FMMLRNYIECF(this IRRSNCQWIPE a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x88DB8E0", Offset = "0x88DA8E0", VA = "0x1888DB8E0")]
		public static string WNVQWNCSOFR(this IRRSNCQWIPE a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x88DB260", Offset = "0x88DA260", VA = "0x1888DB260")]
		private static string KFLTNGDNSAF(IRRSNCQWIPE a, Func<IRRSNCQWIPE, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x88DB780", Offset = "0x88DA780", VA = "0x1888DB780")]
		public static string SOJJHCDJUCX(this IRRSNCQWIPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x88DB5C0", Offset = "0x88DA5C0", VA = "0x1888DB5C0")]
		public static ViewId RTWXTGKJTIU(this IRRSNCQWIPE a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x88DB350", Offset = "0x88DA350", VA = "0x1888DB350")]
		public static string OWPYFAQPVZG(this IRRSNCQWIPE a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class UAEWEMZYHWZ
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class FCLLBSRNYTX
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static string ISHKZMINKDO;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x88DCC50", Offset = "0x88DBC50", VA = "0x1888DCC50")]
		public static string WLGRGRSJRTI(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(AOVUVLIMJZQ), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class AOVUVLIMJZQ : LXIVYDCSTEJ
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log FTBFSBFBBGJ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log RCENBRLXDOW;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log XTJBSPEZGUA;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] NUYYDGYOCRP
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAD0670", Offset = "0xACF670", VA = "0x180AD0670", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x88DAB30", Offset = "0x88D9B30", VA = "0x1888DAB30", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x88DA9B0", Offset = "0x88D99B0", VA = "0x1888DA9B0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x88DA9A0", Offset = "0x88D99A0", VA = "0x1888DA9A0")]
		private void ITERPWCPIZF(IRRSNCQWIPE a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x88DAD60", Offset = "0x88D9D60", VA = "0x1888DAD60")]
		private void XOPMPQACEES(IRRSNCQWIPE a, GWGBIKXISIV b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x88DA780", Offset = "0x88D9780", VA = "0x1888DA780")]
		public void BQUNTZHZOCG(IRRSNCQWIPE a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x88DACB0", Offset = "0x88D9CB0", VA = "0x1888DACB0")]
		private static Log TVHHOVJOCTM(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x88DAE40", Offset = "0x88D9E40", VA = "0x1888DAE40")]
		public AOVUVLIMJZQ()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class ZXACQFYXUQV
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
		private static readonly JsonSerializerSettings ABYLFCFJPRS;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x88DEB70", Offset = "0x88DDB70", VA = "0x1888DEB70")]
		public static EventWriter XIYZQQIYBYC([In] this EventWriter evt, IRRSNCQWIPE a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x88DE250", Offset = "0x88DD250", VA = "0x1888DE250")]
		public static EventWriter REZCYAEMHPL([In] this EventWriter evt, IRRSNCQWIPE a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x88DE5A0", Offset = "0x88DD5A0", VA = "0x1888DE5A0")]
		public static string VUWCJGLMFGG(IRRSNCQWIPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x88DE780", Offset = "0x88DD780", VA = "0x1888DE780")]
		public static string WHBUBOBVOXL(IRRSNCQWIPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x88DE9E0", Offset = "0x88DD9E0", VA = "0x1888DE9E0")]
		public static string WJUKKALLRFT(IRRSNCQWIPE a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x88DE060", Offset = "0x88DD060", VA = "0x1888DE060")]
		[CompilerGenerated]
		internal static bool CYAHDLECALP([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x88DE0F0", Offset = "0x88DD0F0", VA = "0x1888DE0F0")]
		[CompilerGenerated]
		internal static bool EEZVVZHVYXO([Out] string a, <>c__DisplayClass6_0 b)
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
