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
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A11E00", Offset = "0x9A10A00", VA = "0x189A11E00")]
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
	[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A11C00", Offset = "0x9A10800", VA = "0x189A11C00", Slot = "4")]
		public override void SIFQFAPRLAF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD18E40", Offset = "0xD17A40", VA = "0x180D18E40")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4300", Offset = "0xCF2F00", VA = "0x180CF4300", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x223B070", Offset = "0x2239C70", VA = "0x18223B070", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x9A14580", Offset = "0x9A13180", VA = "0x189A14580")]
		private void GVEYSKBSPJB(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x9A14280", Offset = "0x9A12E80", VA = "0x189A14280")]
		private void GUZRVDHVFXS(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x9A14930", Offset = "0x9A13530", VA = "0x189A14930", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x9A149E0", Offset = "0x9A135E0", VA = "0x189A149E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A10750", Offset = "0x9A0F350", VA = "0x189A10750", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId JXNAEWQJFHH
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x9A10E40", Offset = "0x9A0FA40", VA = "0x189A10E40", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool EPIWWBMRZHA
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD39F40", Offset = "0xD38B40", VA = "0x180D39F40", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool ZPIBEJAPNOJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x9A10C50", Offset = "0x9A0F850", VA = "0x189A10C50", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x9A11220", Offset = "0x9A0FE20", VA = "0x189A11220", Slot = "9")]
			public bool XTJZGYYVHYS([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCF4310", Offset = "0xCF2F10", VA = "0x180CF4310", Slot = "8")]
			public object OTXTCZBQXPK()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x9A107A0", Offset = "0x9A0F3A0", VA = "0x189A107A0", Slot = "10")]
			private (PlayerId, object) GWWPXFBKOCI()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x9A10B60", Offset = "0x9A0F760", VA = "0x189A10B60", Slot = "11")]
			private (ObjectNetworkId, PlayerId) KCRGYDIOFBS()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x9A112F0", Offset = "0x9A0FEF0", VA = "0x189A112F0", Slot = "12")]
			private CAJIYQQGHAR<(ObjectNetworkId, PlayerId)> YVBNFBLFEOX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x9A10930", Offset = "0x9A0F530", VA = "0x189A10930", Slot = "13")]
			private (OutOfBandMessageType, byte[]) JKYSPKHFXZF()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x9A10E90", Offset = "0x9A0FA90", VA = "0x189A10E90", Slot = "14")]
			private (PacketSource, byte[]) TALJFZDFADK()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x41486A0", Offset = "0x41472A0", VA = "0x1841486A0", Slot = "15")]
			public a CVNGPMTOKUP<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x9A11130", Offset = "0x9A0FD30", VA = "0x189A11130", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
				[Cpp2IlInjected.Address(RVA = "0x9A11B40", Offset = "0x9A10740", VA = "0x189A11B40", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x9A11B60", Offset = "0x9A10760", VA = "0x189A11B60", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public KXUKOBBZMPP()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x9A11420", Offset = "0x9A10020", VA = "0x189A11420", Slot = "4")]
		public bool VPWDAIBPJGY(object a, JHVMANSCQQR b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A12200", Offset = "0x9A10E00", VA = "0x189A12200", Slot = "4")]
		public void InitReferences(PPCVAYWFABF services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x9A12750", Offset = "0x9A11350", VA = "0x189A12750", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x9A122E0", Offset = "0x9A10EE0", VA = "0x189A122E0", Slot = "6")]
		public void LBDVXHTLWXZ(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x9A127F0", Offset = "0x9A113F0", VA = "0x189A127F0", Slot = "10")]
		public void XPRJIQXLOVO(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x9A12540", Offset = "0x9A11140", VA = "0x189A12540", Slot = "7")]
		public void ODYYFDWSNSB(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x9A11EE0", Offset = "0x9A10AE0", VA = "0x189A11EE0")]
		private IDictionary<object, object> HEHLAEFPWIY(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x9A11E80", Offset = "0x9A10A80", VA = "0x189A11E80")]
		public void FGHHYFWTLMH(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x9A124D0", Offset = "0x9A110D0", VA = "0x189A124D0", Slot = "8")]
		private void MMZJSGUTRHN(PPCVAYWFABF a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x102F010", Offset = "0x102DC10", VA = "0x18102F010", Slot = "9")]
		private void IKBYUUMLEVN()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x9A12A00", Offset = "0x9A11600", VA = "0x189A12A00")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9A11D50", Offset = "0x9A10950", VA = "0x189A11D50")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A14030", Offset = "0x9A12C30", VA = "0x189A14030", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x9A14230", Offset = "0x9A12E30", VA = "0x189A14230")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF6450", Offset = "0xCF5050", VA = "0x180CF6450")]
			public QMUJENUQTSD()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x9A12A80", Offset = "0x9A11680", VA = "0x189A12A80")]
			internal string ZMAMSYOAGEI(VZMXLASXEMR a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x9A13D10", Offset = "0x9A12910", VA = "0x189A13D10")]
		public static string RJWFQVLLTZQ(this VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x9A136A0", Offset = "0x9A122A0", VA = "0x189A136A0")]
		public static NetworkEventType ASZIVIAOFPD(this VZMXLASXEMR a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x9A13AF0", Offset = "0x9A126F0", VA = "0x189A13AF0")]
		public static ViewId NCSGWBNUGIY(this VZMXLASXEMR a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x9A137E0", Offset = "0x9A123E0", VA = "0x189A137E0")]
		public static string JJGGZBAHLHU(this VZMXLASXEMR a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x9A138A0", Offset = "0x9A124A0", VA = "0x189A138A0")]
		private static string LNRGTNGJCSM(VZMXLASXEMR a, Func<VZMXLASXEMR, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x9A13990", Offset = "0x9A12590", VA = "0x189A13990")]
		public static string MULUCAZKPZO(this VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x9A13D30", Offset = "0x9A12930", VA = "0x189A13D30")]
		public static ViewId WMHQZVJRMYV(this VZMXLASXEMR a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x9A13F20", Offset = "0x9A12B20", VA = "0x189A13F20")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A11530", Offset = "0x9A10130", VA = "0x189A11530")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF1D90", Offset = "0xCF0990", VA = "0x180CF1D90", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x9A12E00", Offset = "0x9A11A00", VA = "0x189A12E00", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x9A12C80", Offset = "0x9A11880", VA = "0x189A12C80", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x9A12BC0", Offset = "0x9A117C0", VA = "0x189A12BC0")]
		private void EDJNIZJNYMM(VZMXLASXEMR a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x9A12F80", Offset = "0x9A11B80", VA = "0x189A12F80")]
		private void SRPNJUVPGPP(VZMXLASXEMR a, SVLVGVMSMLM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x9A12FB0", Offset = "0x9A11BB0", VA = "0x189A12FB0")]
		public void VJIJRJOMKDJ(VZMXLASXEMR a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x9A12BD0", Offset = "0x9A117D0", VA = "0x189A12BD0")]
		private static Log LTIOTVLISBX(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x9A13280", Offset = "0x9A11E80", VA = "0x189A13280")]
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
		[Cpp2IlInjected.Address(RVA = "0x9A0EED0", Offset = "0x9A0DAD0", VA = "0x189A0EED0")]
		public static EventWriter CRGHIWRTLBL([In] this EventWriter evt, VZMXLASXEMR a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x9A0FA70", Offset = "0x9A0E670", VA = "0x189A0FA70")]
		public static EventWriter DQNYBIJDAZE([In] this EventWriter evt, VZMXLASXEMR a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9A100B0", Offset = "0x9A0ECB0", VA = "0x189A100B0")]
		public static string JPCLGRLJYXX(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x9A0FE50", Offset = "0x9A0EA50", VA = "0x189A0FE50")]
		public static string IWAGFJLTRQU(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9A103F0", Offset = "0x9A0EFF0", VA = "0x189A103F0")]
		public static string URGIXOVMEGK(VZMXLASXEMR a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9A0FDC0", Offset = "0x9A0E9C0", VA = "0x189A0FDC0")]
		[CompilerGenerated]
		internal static bool DZCKXPUEJUW([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9A10290", Offset = "0x9A0EE90", VA = "0x189A10290")]
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
