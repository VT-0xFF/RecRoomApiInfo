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
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x994B770", Offset = "0x994AB70", VA = "0x18994B770")]
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
	[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x994B670", Offset = "0x994AA70", VA = "0x18994B670", Slot = "4")]
		public override void GZVUEGYMGMP()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xD1E1A0", Offset = "0xD1D5A0", VA = "0x180D1E1A0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCF4C30", Offset = "0xCF4030", VA = "0x180CF4C30", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x223B2D0", Offset = "0x223A6D0", VA = "0x18223B2D0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x994E910", Offset = "0x994DD10", VA = "0x18994E910")]
		private void BAZLOGTATAR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x994E5F0", Offset = "0x994D9F0", VA = "0x18994E5F0")]
		private void BAUEQZZDJPI(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x994ECC0", Offset = "0x994E0C0", VA = "0x18994ECC0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x994ED70", Offset = "0x994E170", VA = "0x18994ED70")]
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
				[Cpp2IlInjected.Address(RVA = "0x994DCF0", Offset = "0x994D0F0", VA = "0x18994DCF0", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId YNXBKDDXBMX
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x994DF30", Offset = "0x994D330", VA = "0x18994DF30", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool IGADIFNDMVC
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xD3ECB0", Offset = "0xD3E0B0", VA = "0x180D3ECB0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool DLWGNFCRNCD
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x994E290", Offset = "0x994D690", VA = "0x18994E290", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x994DD40", Offset = "0x994D140", VA = "0x18994DD40", Slot = "9")]
			public bool LSQELRRDJMU([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xCF4CE0", Offset = "0xCF40E0", VA = "0x180CF4CE0", Slot = "8")]
			public object JQAVZALKTWS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x994DB60", Offset = "0x994CF60", VA = "0x18994DB60", Slot = "10")]
			private (PlayerId, object) GAXGJWKUYFI()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x994E4A0", Offset = "0x994D8A0", VA = "0x18994E4A0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) XUOVCBHDGRQ()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x994DE00", Offset = "0x994D200", VA = "0x18994DE00", Slot = "12")]
			private OALTWBMPPFJ<(ObjectNetworkId, PlayerId)> ODIQUYLBFND()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x994DF80", Offset = "0x994D380", VA = "0x18994DF80", Slot = "13")]
			private (OutOfBandMessageType, byte[]) STOFPMSJYON()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x994D8D0", Offset = "0x994CCD0", VA = "0x18994D8D0", Slot = "14")]
			private (PacketSource, byte[]) ATWDAMKMUVQ()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x415F6C0", Offset = "0x415EAC0", VA = "0x18415F6C0", Slot = "15")]
			public a IEXTXXQELIN<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x994E1A0", Offset = "0x994D5A0", VA = "0x18994E1A0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
				[Cpp2IlInjected.Address(RVA = "0x994D810", Offset = "0x994CC10", VA = "0x18994D810", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x994D830", Offset = "0x994CC30", VA = "0x18994D830", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public WPGTWRRZYAL()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x99493D0", Offset = "0x99487D0", VA = "0x1899493D0", Slot = "4")]
		public bool SYQOKEJVQMS(object a, HUHHCTUVUPJ b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
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
		[Cpp2IlInjected.Address(RVA = "0x994C150", Offset = "0x994B550", VA = "0x18994C150", Slot = "4")]
		public void InitReferences(GEZRGCKOUXX services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x994C510", Offset = "0x994B910", VA = "0x18994C510", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x994BF60", Offset = "0x994B360", VA = "0x18994BF60", Slot = "6")]
		public void HSTCVBXPHEF(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x994C5B0", Offset = "0x994B9B0", VA = "0x18994C5B0", Slot = "10")]
		public void XFDNYNEEPVM(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x994C290", Offset = "0x994B690", VA = "0x18994C290", Slot = "7")]
		public void LAKHSBYTACP(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x994C730", Offset = "0x994BB30", VA = "0x18994C730")]
		private IDictionary<object, object> ZHHOGHKQUMO(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x994C230", Offset = "0x994B630", VA = "0x18994C230")]
		public void JQBTEKHXHIZ(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x994C4A0", Offset = "0x994B8A0", VA = "0x18994C4A0", Slot = "8")]
		private void LJERCYKGCZL(GEZRGCKOUXX a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0x102E920", Offset = "0x102DD20", VA = "0x18102E920", Slot = "9")]
		private void XGDIBOIJOEF()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x994CAD0", Offset = "0x994BED0", VA = "0x18994CAD0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x9949320", Offset = "0x9948720", VA = "0x189949320")]
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
		[Cpp2IlInjected.Address(RVA = "0x99494E0", Offset = "0x99488E0", VA = "0x1899494E0", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x99496D0", Offset = "0x9948AD0", VA = "0x1899496D0")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFCAD0", Offset = "0xCFBED0", VA = "0x180CFCAD0")]
			public JZPSQTWWHKR()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x994AF20", Offset = "0x994A320", VA = "0x18994AF20")]
			internal string APWSEAYQAGW(FAOJZRJMKFV a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x994D6B0", Offset = "0x994CAB0", VA = "0x18994D6B0")]
		public static string XFZZBWPSZRO(this FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x994D6D0", Offset = "0x994CAD0", VA = "0x18994D6D0")]
		public static NetworkEventType YWRGFPMTQSD(this FAOJZRJMKFV a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x994CE80", Offset = "0x994C280", VA = "0x18994CE80")]
		public static ViewId BBRVHMHDIYW(this FAOJZRJMKFV a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x994D3F0", Offset = "0x994C7F0", VA = "0x18994D3F0")]
		public static string UTZXQCPUZIM(this FAOJZRJMKFV a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x994D4B0", Offset = "0x994C8B0", VA = "0x18994D4B0")]
		private static string VLMWRKSKJMG(FAOJZRJMKFV a, Func<FAOJZRJMKFV, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x994D0A0", Offset = "0x994C4A0", VA = "0x18994D0A0")]
		public static string CZYCTZGCTWO(this FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x994D1F0", Offset = "0x994C5F0", VA = "0x18994D1F0")]
		public static ViewId KKADCXCIAHZ(this FAOJZRJMKFV a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x994D5A0", Offset = "0x994C9A0", VA = "0x18994D5A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x994B060", Offset = "0x994A460", VA = "0x18994B060")]
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
			[Cpp2IlInjected.Address(RVA = "0xCFB370", Offset = "0xCFA770", VA = "0x180CFB370", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x994BC40", Offset = "0x994B040", VA = "0x18994BC40", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x994BAD0", Offset = "0x994AED0", VA = "0x18994BAD0", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x994B7F0", Offset = "0x994ABF0", VA = "0x18994B7F0")]
		private void JCPEPACSOCO(FAOJZRJMKFV a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x994BDB0", Offset = "0x994B1B0", VA = "0x18994BDB0")]
		private void PTPZWLGERFB(FAOJZRJMKFV a, GTCQSIYUTCU b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x994B800", Offset = "0x994AC00", VA = "0x18994B800")]
		public void JODVXZHJEUZ(FAOJZRJMKFV a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x994BA20", Offset = "0x994AE20", VA = "0x18994BA20")]
		private static Log OAKCSKZKZBR(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x994BE80", Offset = "0x994B280", VA = "0x18994BE80")]
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
		[Cpp2IlInjected.Address(RVA = "0x9949C90", Offset = "0x9949090", VA = "0x189949C90")]
		public static EventWriter XJJJLHWGTZZ([In] this EventWriter evt, FAOJZRJMKFV a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x994AA30", Offset = "0x9949E30", VA = "0x18994AA30")]
		public static EventWriter ZOACQUXGZRS([In] this EventWriter evt, FAOJZRJMKFV a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x9949720", Offset = "0x9948B20", VA = "0x189949720")]
		public static string ALSFNVYBIUH(FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x994A7D0", Offset = "0x9949BD0", VA = "0x18994A7D0")]
		public static string YCAGRGKWFQO(FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x9949990", Offset = "0x9948D90", VA = "0x189949990")]
		public static string MGCDZWARYLO(FAOJZRJMKFV a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x9949900", Offset = "0x9948D00", VA = "0x189949900")]
		[CompilerGenerated]
		internal static bool DBLYTAOOLDC([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x9949B30", Offset = "0x9948F30", VA = "0x189949B30")]
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
