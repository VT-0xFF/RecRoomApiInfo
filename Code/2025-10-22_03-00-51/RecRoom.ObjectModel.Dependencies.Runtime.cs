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
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x86C10B0", Offset = "0x86BF6B0", VA = "0x1886C10B0")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class ZFXGPLLYWZU
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
	[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
	public ZFXGPLLYWZU()
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
		[Cpp2IlInjected.Address(RVA = "0x86C0320", Offset = "0x86BE920", VA = "0x1886C0320", Slot = "4")]
		public override void KQPXXDZDTRT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAD08C0", Offset = "0xACEEC0", VA = "0x180AD08C0")]
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
		private int[] TPUBNGGXPOQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] TPZIKNAUYZZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset EHSYFWCIGXF;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset EHNRIPIKXLW;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] IDNCONLMKKO;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAAFEF0", Offset = "0xAAE4F0", VA = "0x180AAFEF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x241FAE0", Offset = "0x241E0E0", VA = "0x18241FAE0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x86C4350", Offset = "0x86C2950", VA = "0x1886C4350")]
		private void UAFZRFJIDZJ(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x86C4060", Offset = "0x86C2660", VA = "0x1886C4060")]
		private void UAASTYPKUOA(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x86C3FB0", Offset = "0x86C25B0", VA = "0x1886C3FB0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x86C46F0", Offset = "0x86C2CF0", VA = "0x1886C46F0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(DUFTUQMSXRH), new string[] { "Photon" })]
	public class HHJXGAIOJTK : DUFTUQMSXRH
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class NWXVOKNRHWK : VMBFRJHVPND
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public KMNYUBYLMOF WAYWWTMVFKY;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public StatusCode LJHJASROWUH;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public OUWINWULOQV MIHJKVNMVJX;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType BTZTINVWBHG
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x86C0F70", Offset = "0x86BF570", VA = "0x1886C0F70", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId MELQJXGPJAV
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x86C0920", Offset = "0x86BEF20", VA = "0x1886C0920", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool KYNRFQZNGFI
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x86C06E0", Offset = "0x86BECE0", VA = "0x1886C06E0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool QVZDMQIQEFX
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x86C0CC0", Offset = "0x86BF2C0", VA = "0x1886C0CC0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x86C0970", Offset = "0x86BEF70", VA = "0x1886C0970", Slot = "9")]
			public bool IZQYXDCRLXU([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x86C0A40", Offset = "0x86BF040", VA = "0x1886C0A40", Slot = "8")]
			public object PMVHQMANAWA()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x86C0550", Offset = "0x86BEB50", VA = "0x1886C0550", Slot = "10")]
			private (PlayerId, object) DIQKIDAOTXK()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x86C0FC0", Offset = "0x86BF5C0", VA = "0x1886C0FC0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) YXRTQIXXNFK()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x86C0420", Offset = "0x86BEA20", VA = "0x1886C0420", Slot = "12")]
			private KLNVRLWGEBL<(ObjectNetworkId, PlayerId)> AZVZVVAMKJR()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x86C06F0", Offset = "0x86BECF0", VA = "0x1886C06F0", Slot = "13")]
			private (OutOfBandMessageType, byte[]) HFFLCPFVOFJ()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x86C0A90", Offset = "0x86BF090", VA = "0x1886C0A90", Slot = "14")]
			private (PacketSource, byte[]) SZUFVSHIOYQ()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3F12320", Offset = "0x3F10920", VA = "0x183F12320", Slot = "15")]
			public a JGQIWVNGIKT<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x86C0E80", Offset = "0x86BF480", VA = "0x1886C0E80", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public NWXVOKNRHWK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class OUWINWULOQV : KLNVRLWGEBL<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int[] JFXNIXEXMGK;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int VQADIKBXVTK
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x86C1130", Offset = "0x86BF730", VA = "0x1886C1130", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x86C1150", Offset = "0x86BF750", VA = "0x1886C1150", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public OUWINWULOQV()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x86C01A0", Offset = "0x86BE7A0", VA = "0x1886C01A0", Slot = "4")]
		public bool IXSFUJNOUNW(object a, VMBFRJHVPND b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
		public HHJXGAIOJTK()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class OLIXANLLNKP
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(USRAYLNVKPG), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : UTOILWCTUPI, BZCVNEBXNRM, USRAYLNVKPG, GIIGMTDPOEP, SWFXCOYYPIH
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Log WOAZIZZDVRE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private QKAPHQYONNA FWGLOYCYIPP;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[DependsOn]
		private NPBFDPXSNNT MFLSNWAWPIR;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Hashtable QVICMYQMOGZ;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x86C1250", Offset = "0x86BF850", VA = "0x1886C1250", Slot = "4")]
		public void InitReferences(XRIYJCZWKCD services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x86C1710", Offset = "0x86BFD10", VA = "0x1886C1710", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x86C1940", Offset = "0x86BFF40", VA = "0x1886C1940", Slot = "6")]
		public void YAYZNGADQSL(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x86C15F0", Offset = "0x86BFBF0", VA = "0x1886C15F0", Slot = "10")]
		public void SKGBALEJCDK(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x86C17B0", Offset = "0x86BFDB0", VA = "0x1886C17B0", Slot = "7")]
		public void UHRRQXVKUAR(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x86C13A0", Offset = "0x86BF9A0", VA = "0x1886C13A0")]
		private Hashtable OQQIALTWNCY(Hashtable a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x86C11F0", Offset = "0x86BF7F0", VA = "0x1886C11F0")]
		public void HRVRANTSQAL(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x86C1330", Offset = "0x86BF930", VA = "0x1886C1330", Slot = "8")]
		private void KPEUJIHXKXR(XRIYJCZWKCD a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x1091A50", Offset = "0x1090050", VA = "0x181091A50", Slot = "9")]
		private void WCDWJAGTXKX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x86C1B20", Offset = "0x86C0120", VA = "0x1886C1B20")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.WLTQWRNKXSX), new string[] { })]
	internal class HEHIYDULNFY : IUBEHILJBSI, RecRoom.RoomLoading.RoomOperation.WLTQWRNKXSX
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log TVHBCHXLAEV;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] NASDTXZWBNM
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x86C00F0", Offset = "0x86BE6F0", VA = "0x1886C00F0")]
		public HEHIYDULNFY()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class WJCOHILCYGN : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x86C1E90", Offset = "0x86C0490", VA = "0x1886C1E90", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x86C2080", Offset = "0x86C0680", VA = "0x1886C2080")]
		public WJCOHILCYGN()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class BWHMRLGDVAC
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class XIPYLIIUTHZ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public JsonSerializerSettings KHBETHONUSN;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAAE1D0", Offset = "0xAAC7D0", VA = "0x180AAE1D0")]
			public XIPYLIIUTHZ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x86C20D0", Offset = "0x86C06D0", VA = "0x1886C20D0")]
			internal string BCWMPPCVLAM(KMNYUBYLMOF a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x86BECB0", Offset = "0x86BD2B0", VA = "0x1886BECB0")]
		public static string IHUHCJRBZJA(this KMNYUBYLMOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x86BECD0", Offset = "0x86BD2D0", VA = "0x1886BECD0")]
		public static NetworkEventType KNQCDVHOVIB(this KMNYUBYLMOF a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x86BEF20", Offset = "0x86BD520", VA = "0x1886BEF20")]
		public static ViewId SPMJQDLLNBC(this KMNYUBYLMOF a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x86BF260", Offset = "0x86BD860", VA = "0x1886BF260")]
		public static string VYFKHKHUBPM(this KMNYUBYLMOF a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x86BEBC0", Offset = "0x86BD1C0", VA = "0x1886BEBC0")]
		private static string FMZPOKDGIIY(KMNYUBYLMOF a, Func<KMNYUBYLMOF, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x86BF110", Offset = "0x86BD710", VA = "0x1886BF110")]
		public static string UGEZWBSEKVS(this KMNYUBYLMOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x86BEA00", Offset = "0x86BD000", VA = "0x1886BEA00")]
		public static ViewId AYGRGEEAUBL(this KMNYUBYLMOF a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x86BEE10", Offset = "0x86BD410", VA = "0x1886BEE10")]
		public static string LJEDPCEWUKD(this KMNYUBYLMOF a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class FHPMCXWBIDQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class YBSNLSJXJYG
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static string EIEFMZKSIFL;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x86BFA90", Offset = "0x86BE090", VA = "0x1886BFA90")]
		public static string JGOVAVIVYTP(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(EQRUNGHMUGP), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class EQRUNGHMUGP : IUBEHILJBSI
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log WBFSDEKBUHS;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log TVZOWBAFXDR;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log MCCEXPZTUZL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] NASDTXZWBNM
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA7750", Offset = "0xAA5D50", VA = "0x180AA7750", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x86BF6E0", Offset = "0x86BDCE0", VA = "0x1886BF6E0", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x86BF570", Offset = "0x86BDB70", VA = "0x1886BF570", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x86BF850", Offset = "0x86BDE50", VA = "0x1886BF850")]
		private void QZITIKYXXUY(KMNYUBYLMOF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x86BF540", Offset = "0x86BDB40", VA = "0x1886BF540")]
		private void OIPFUDYGCEN(KMNYUBYLMOF a, KAUBEGREKJA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x86BF320", Offset = "0x86BD920", VA = "0x1886BF320")]
		public void ANXUTDRHMUH(KMNYUBYLMOF a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x86BF860", Offset = "0x86BDE60", VA = "0x1886BF860")]
		private static Log XGQCCWFLIFX(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x86BF9B0", Offset = "0x86BDFB0", VA = "0x1886BF9B0")]
		public EQRUNGHMUGP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class ZMPNZMCOKQC
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
		private static readonly JsonSerializerSettings VSFPGVPDKLZ;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x86C28D0", Offset = "0x86C0ED0", VA = "0x1886C28D0")]
		public static EventWriter PJSXSKNFFSR([In] this EventWriter evt, KMNYUBYLMOF a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x86C3950", Offset = "0x86C1F50", VA = "0x1886C3950")]
		public static EventWriter QBYDEHNATOG([In] this EventWriter evt, KMNYUBYLMOF a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x86C2400", Offset = "0x86C0A00", VA = "0x1886C2400")]
		public static string LGOPGREFHJP(KMNYUBYLMOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x86C25E0", Offset = "0x86C0BE0", VA = "0x1886C25E0")]
		public static string NOGNBPRBQHK(KMNYUBYLMOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x86C2270", Offset = "0x86C0870", VA = "0x1886C2270")]
		public static string IATJBYRKWFU(KMNYUBYLMOF a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x86C2840", Offset = "0x86C0E40", VA = "0x1886C2840")]
		[CompilerGenerated]
		internal static bool NXWMWYEMGLE([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x86C3CA0", Offset = "0x86C22A0", VA = "0x1886C3CA0")]
		[CompilerGenerated]
		internal static bool ZHGGUIKMGOH([Out] string a, <>c__DisplayClass6_0 b)
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
