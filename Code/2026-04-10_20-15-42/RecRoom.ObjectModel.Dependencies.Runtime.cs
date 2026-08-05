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
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		[Cpp2IlInjected.Address(RVA = "0x9BB3140", Offset = "0x9BB2140", VA = "0x189BB3140")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class SVGOSYYBXCW
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
	[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
	public SVGOSYYBXCW()
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
		[Cpp2IlInjected.Address(RVA = "0x9BB2F40", Offset = "0x9BB1F40", VA = "0x189BB2F40", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD34090", Offset = "0xD33090", VA = "0x180D34090")]
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
		private int[] FEHXVDYRGKU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] FENESKSOPWD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset GXKYIJVMEXV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset GXFRLDBOVMM;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] VOPGUSAZNLY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3B0", Offset = "0xD0E3B0", VA = "0x180D0F3B0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x2255D00", Offset = "0x2254D00", VA = "0x182255D00", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9BB58C0", Offset = "0x9BB48C0", VA = "0x189BB58C0")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9BB55C0", Offset = "0x9BB45C0", VA = "0x189BB55C0")]
		private void GUZRVDHVFXS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5C70", Offset = "0x9BB4C70", VA = "0x189BB5C70", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5D20", Offset = "0x9BB4D20", VA = "0x189BB5D20")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(GVWRNBYTFSF), new string[] { "Photon" })]
	public class JVRQVVXKTHC : GVWRNBYTFSF
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class ITAYHILKFHI : JHVMANSCQQR
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public VZMXLASXEMR MTSIVAAIAPK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public KXUKOBBZMPP AYEIAFGTJYR;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType XYUHIEMAMOM
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x9BB1A90", Offset = "0x9BB0A90", VA = "0x189BB1A90", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId JXNAEWQJFHH
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x9BB2180", Offset = "0x9BB1180", VA = "0x189BB2180", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool EPIWWBMRZHA
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD55280", Offset = "0xD54280", VA = "0x180D55280", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool ZPIBEJAPNOJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x9BB1F90", Offset = "0x9BB0F90", VA = "0x189BB1F90", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9BB2560", Offset = "0x9BB1560", VA = "0x189BB2560", Slot = "9")]
			public bool XTJZGYYVHYS([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xD0F3C0", Offset = "0xD0E3C0", VA = "0x180D0F3C0", Slot = "8")]
			public object OTXTCZBQXPK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9BB1AE0", Offset = "0x9BB0AE0", VA = "0x189BB1AE0", Slot = "10")]
			private (PlayerId, object) GWWPXFBKOCI()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9BB1EA0", Offset = "0x9BB0EA0", VA = "0x189BB1EA0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) KCRGYDIOFBS()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9BB2630", Offset = "0x9BB1630", VA = "0x189BB2630", Slot = "12")]
			private CAJIYQQGHAR<(ObjectNetworkId, PlayerId)> YVBNFBLFEOX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9BB1C70", Offset = "0x9BB0C70", VA = "0x189BB1C70", Slot = "13")]
			private (OutOfBandMessageType, byte[]) JKYSPKHFXZF()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9BB21D0", Offset = "0x9BB11D0", VA = "0x189BB21D0", Slot = "14")]
			private (PacketSource, byte[]) TALJFZDFADK()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x4163740", Offset = "0x4162740", VA = "0x184163740", Slot = "15")]
			public a CVNGPMTOKUP<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9BB2470", Offset = "0x9BB1470", VA = "0x189BB2470", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public ITAYHILKFHI()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class KXUKOBBZMPP : CAJIYQQGHAR<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] WDSTHOLEDTM;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int HSBKFDGFQWY
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x9BB2E80", Offset = "0x9BB1E80", VA = "0x189BB2E80", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x9BB2EA0", Offset = "0x9BB1EA0", VA = "0x189BB2EA0", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public KXUKOBBZMPP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2760", Offset = "0x9BB1760", VA = "0x189BB2760", Slot = "4")]
		public bool VPWDAIBPJGY(object a, JHVMANSCQQR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
		public JVRQVVXKTHC()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class MPPZTODLAXJ
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(OFIEPGEIVKM), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : DTRQAXWKVLM, CYNTNYLLHQW, OFIEPGEIVKM, CJJGAWHPXAL, KXJYMNDEBYH
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log KZEIFDHBWKO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private SVVKGAIGFCG PRVYSIDAWZL;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private URCPEIKCZIN UYTDVMTXYBD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> YOEGLOZXQXH;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3540", Offset = "0x9BB2540", VA = "0x189BB3540", Slot = "4")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3A90", Offset = "0x9BB2A90", VA = "0x189BB3A90", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3620", Offset = "0x9BB2620", VA = "0x189BB3620", Slot = "6")]
		public void LBDVXHTLWXZ(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3B30", Offset = "0x9BB2B30", VA = "0x189BB3B30", Slot = "10")]
		public void XPRJIQXLOVO(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3880", Offset = "0x9BB2880", VA = "0x189BB3880", Slot = "7")]
		public void ODYYFDWSNSB(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3220", Offset = "0x9BB2220", VA = "0x189BB3220")]
		private IDictionary<object, object> HEHLAEFPWIY(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9BB31C0", Offset = "0x9BB21C0", VA = "0x189BB31C0")]
		public void FGHHYFWTLMH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3810", Offset = "0x9BB2810", VA = "0x189BB3810", Slot = "8")]
		private void MMZJSGUTRHN(PPCVAYWFABF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x104ABF0", Offset = "0x1049BF0", VA = "0x18104ABF0", Slot = "9")]
		private void IKBYUUMLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3D40", Offset = "0x9BB2D40", VA = "0x189BB3D40")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.XFULDLVPQCT), new string[] { })]
	internal class MAKHRPVHMPQ : SCPMZAUZQEA, RecRoom.RoomLoading.RoomOperation.XFULDLVPQCT
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log JKBUDZJCQJT;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] OAGVARRRFGC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3090", Offset = "0x9BB2090", VA = "0x189BB3090")]
		public MAKHRPVHMPQ()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class YZHPLMEMWNH : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5370", Offset = "0x9BB4370", VA = "0x189BB5370", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5570", Offset = "0x9BB4570", VA = "0x189BB5570")]
		public YZHPLMEMWNH()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class WEUYYVRWIHQ
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class QMUJENUQTSD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings WIILUUGPPOR;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xD11530", Offset = "0xD10530", VA = "0x180D11530")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9BB3DC0", Offset = "0x9BB2DC0", VA = "0x189BB3DC0")]
			internal string ZMAMSYOAGEI(VZMXLASXEMR a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5050", Offset = "0x9BB4050", VA = "0x189BB5050")]
		public static string RJWFQVLLTZQ(this VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9BB49E0", Offset = "0x9BB39E0", VA = "0x189BB49E0")]
		public static NetworkEventType ASZIVIAOFPD(this VZMXLASXEMR a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9BB4E30", Offset = "0x9BB3E30", VA = "0x189BB4E30")]
		public static ViewId NCSGWBNUGIY(this VZMXLASXEMR a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9BB4B20", Offset = "0x9BB3B20", VA = "0x189BB4B20")]
		public static string JJGGZBAHLHU(this VZMXLASXEMR a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9BB4BE0", Offset = "0x9BB3BE0", VA = "0x189BB4BE0")]
		private static string LNRGTNGJCSM(VZMXLASXEMR a, Func<VZMXLASXEMR, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9BB4CD0", Offset = "0x9BB3CD0", VA = "0x189BB4CD0")]
		public static string MULUCAZKPZO(this VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5070", Offset = "0x9BB4070", VA = "0x189BB5070")]
		public static ViewId WMHQZVJRMYV(this VZMXLASXEMR a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9BB5260", Offset = "0x9BB4260", VA = "0x189BB5260")]
		public static string ZHBPGZWLNTF(this VZMXLASXEMR a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class KNXWYKDFJWG
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class AFPWIEYKGEK
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string WWNRCTDPFVX;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x9BB2870", Offset = "0x9BB1870", VA = "0x189BB2870")]
		public static string UZYJLMRUSBL(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(TCLRGAJKAWX), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class TCLRGAJKAWX : SCPMZAUZQEA
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log SYMZRGGCRWI;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log HXMICAPFCZR;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log ZXCLNHBZKWJ;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] OAGVARRRFGC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xD0CE10", Offset = "0xD0BE10", VA = "0x180D0CE10", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9BB4140", Offset = "0x9BB3140", VA = "0x189BB4140", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3FC0", Offset = "0x9BB2FC0", VA = "0x189BB3FC0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3F00", Offset = "0x9BB2F00", VA = "0x189BB3F00")]
		private void EDJNIZJNYMM(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9BB42C0", Offset = "0x9BB32C0", VA = "0x189BB42C0")]
		private void SRPNJUVPGPP(VZMXLASXEMR a, SVLVGVMSMLM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9BB42F0", Offset = "0x9BB32F0", VA = "0x189BB42F0")]
		public void VJIJRJOMKDJ(VZMXLASXEMR a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9BB3F10", Offset = "0x9BB2F10", VA = "0x189BB3F10")]
		private static Log LTIOTVLISBX(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9BB45C0", Offset = "0x9BB35C0", VA = "0x189BB45C0")]
		public TCLRGAJKAWX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class EFWVUPLZBUO
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
		private static readonly JsonSerializerSettings RNMBTNWHHQL;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0210", Offset = "0x9BAF210", VA = "0x189BB0210")]
		public static EventWriter CRGHIWRTLBL([In] this EventWriter evt, VZMXLASXEMR a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9BB0DB0", Offset = "0x9BAFDB0", VA = "0x189BB0DB0")]
		public static EventWriter DQNYBIJDAZE([In] this EventWriter evt, VZMXLASXEMR a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9BB13F0", Offset = "0x9BB03F0", VA = "0x189BB13F0")]
		public static string JPCLGRLJYXX(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1190", Offset = "0x9BB0190", VA = "0x189BB1190")]
		public static string IWAGFJLTRQU(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1730", Offset = "0x9BB0730", VA = "0x189BB1730")]
		public static string URGIXOVMEGK(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9BB1100", Offset = "0x9BB0100", VA = "0x189BB1100")]
		[CompilerGenerated]
		internal static bool DZCKXPUEJUW([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9BB15D0", Offset = "0x9BB05D0", VA = "0x189BB15D0")]
		[CompilerGenerated]
		internal static bool PYXABMBWUVR([Out] string a, <>c__DisplayClass6_0 b)
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
