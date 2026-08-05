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
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		[Cpp2IlInjected.Address(RVA = "0x83BDD90", Offset = "0x83BD190", VA = "0x1883BDD90")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class TSDLEFRRTSA
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
	[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
	public TSDLEFRRTSA()
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
		[Cpp2IlInjected.Address(RVA = "0x83BCEB0", Offset = "0x83BC2B0", VA = "0x1883BCEB0", Slot = "4")]
		public override void MKOAUOREKWX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACD060", Offset = "0xACC460", VA = "0x180ACD060")]
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
		private int[] NXGLGIJHSDE;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] NXLSDPDFBON;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset XVMTEOAFOEZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset XVHMHHGIETQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] RLLPGQRGKSY;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA9AA0", Offset = "0xAA8EA0", VA = "0x180AA9AA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F1FA10", Offset = "0x1F1EE10", VA = "0x181F1FA10", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83BF220", Offset = "0x83BE620", VA = "0x1883BF220")]
		private void CRWDOIATXLP(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83BEF10", Offset = "0x83BE310", VA = "0x1883BEF10")]
		private void CRQWRBGWOAG(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83BF5D0", Offset = "0x83BE9D0", VA = "0x1883BF5D0", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83BF680", Offset = "0x83BEA80", VA = "0x1883BF680")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(ZVAGBEWODSH), new string[] { "Photon" })]
	public class QBSUCUXLXUW : ZVAGBEWODSH
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class MWUULPUOXFK : UOURVGEJEOX
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LEKSKUSYOLN OKCCBUFFWBE;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public YDWIJXMARJR RWYUGIMXDPV;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType FHKJLFTGJNM
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x83BCFB0", Offset = "0x83BC3B0", VA = "0x1883BCFB0", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId JKKHKBJKNIT
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x83BD200", Offset = "0x83BC600", VA = "0x1883BD200", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool HSKAFPNQDOQ
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xAECF50", Offset = "0xAEC350", VA = "0x180AECF50", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool WNAAIEEPHVJ
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x83BD000", Offset = "0x83BC400", VA = "0x1883BD000", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x83BDBC0", Offset = "0x83BCFC0", VA = "0x1883BDBC0", Slot = "9")]
			public bool VHAZSTVBSHO([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAA3BF0", Offset = "0xAA2FF0", VA = "0x180AA3BF0", Slot = "8")]
			public object MDCUVFAWPDM()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x83BD940", Offset = "0x83BCD40", VA = "0x1883BD940", Slot = "10")]
			private (PlayerId, object) TXUOGKTOAEO()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83BD620", Offset = "0x83BCA20", VA = "0x1883BD620", Slot = "11")]
			private (ObjectNetworkId, PlayerId) TSEQQPMNYQO()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x83BD4F0", Offset = "0x83BC8F0", VA = "0x1883BD4F0", Slot = "12")]
			private LZULAJJFGOX<(ObjectNetworkId, PlayerId)> QEWSNSDIJJX()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x83BD710", Offset = "0x83BCB10", VA = "0x1883BD710", Slot = "13")]
			private (OutOfBandMessageType, byte[]) TSWCKDVDEPP()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x83BD250", Offset = "0x83BC650", VA = "0x1883BD250", Slot = "14")]
			private (PacketSource, byte[]) OALVGPSCSOK()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C2CDC0", Offset = "0x3C2C1C0", VA = "0x183C2CDC0", Slot = "15")]
			public a FZHKWRKLPOV<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x83BDAD0", Offset = "0x83BCED0", VA = "0x1883BDAD0", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public MWUULPUOXFK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class YDWIJXMARJR : LZULAJJFGOX<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] AZVOQZKHYOE;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int VYHQWEDMMIW
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x83BEE50", Offset = "0x83BE250", VA = "0x1883BEE50", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x83BEE70", Offset = "0x83BE270", VA = "0x1883BEE70", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public YDWIJXMARJR()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83BEA10", Offset = "0x83BDE10", VA = "0x1883BEA10", Slot = "4")]
		public bool WSHLCSULDZQ(object a, UOURVGEJEOX b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
		public QBSUCUXLXUW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class FPJNKRUESKF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(PYANBALIIGO), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : RMHBMYLEQGQ, HPHRDKEJUGA, PYANBALIIGO, CXEKRVIOQAN, MJITMAVCNAB
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log UMMIJRFVMAQ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private QXIYFPTFFOE JCTAOMOJZPN;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private GYXMBYFLRJV VEBTUXPQWHZ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> MPNMWKEKCWL;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83BE4D0", Offset = "0x83BD8D0", VA = "0x1883BE4D0", Slot = "4")]
		public void InitReferences(KHYDBENZVLP services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83BE870", Offset = "0x83BDC70", VA = "0x1883BE870", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83BE680", Offset = "0x83BDA80", VA = "0x1883BE680", Slot = "6")]
		public void OPSEUDNFLFP(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83BE350", Offset = "0x83BD750", VA = "0x1883BE350", Slot = "10")]
		public void EWWZLMDZXGO(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83BDE10", Offset = "0x83BD210", VA = "0x1883BDE10", Slot = "7")]
		public void BFOPJRSLOGL(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83BE020", Offset = "0x83BD420", VA = "0x1883BE020")]
		private IDictionary<object, object> BXGVVHPIEDM(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83BE620", Offset = "0x83BDA20", VA = "0x1883BE620")]
		public void OKQIWPCSQCV(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83BE5B0", Offset = "0x83BD9B0", VA = "0x1883BE5B0", Slot = "8")]
		private void NWFIMGNSGYB(KHYDBENZVLP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD4CB20", Offset = "0xD4BF20", VA = "0x180D4CB20", Slot = "9")]
		private void ILFOPVAQDXX()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83BE990", Offset = "0x83BDD90", VA = "0x1883BE990")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.FWIRGFITYDP), new string[] { })]
	internal class NKPKBQQXUTC : KXMXCULKMAC, RecRoom.RoomLoading.RoomOperation.FWIRGFITYDP
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log YGRMLEPZOEX;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] MTSMVKHGVTS
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83BDCE0", Offset = "0x83BD0E0", VA = "0x1883BDCE0")]
		public NKPKBQQXUTC()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class HIAMVMTQVMT : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83BBDB0", Offset = "0x83BB1B0", VA = "0x1883BBDB0", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83BBFA0", Offset = "0x83BB3A0", VA = "0x1883BBFA0")]
		public HIAMVMTQVMT()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class AXIERPAABIU
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JPVXPIJGEKJ
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings CULRRFDIWLV;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAAB600", Offset = "0xAAAA00", VA = "0x180AAB600")]
			public JPVXPIJGEKJ()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x83BCD70", Offset = "0x83BC170", VA = "0x1883BCD70")]
			internal string VKDVUYOKAYO(LEKSKUSYOLN a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83B9E00", Offset = "0x83B9200", VA = "0x1883B9E00")]
		public static string MHVWRFUIQJO(this LEKSKUSYOLN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83B9BB0", Offset = "0x83B8FB0", VA = "0x1883B9BB0")]
		public static NetworkEventType EQCGRHSHCAT(this LEKSKUSYOLN a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83BA260", Offset = "0x83B9660", VA = "0x1883BA260")]
		public static ViewId RHDXVEKSGJA(this LEKSKUSYOLN a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83BA480", Offset = "0x83B9880", VA = "0x1883BA480")]
		public static string WEJWUNNHZNO(this LEKSKUSYOLN a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83BA020", Offset = "0x83B9420", VA = "0x1883BA020")]
		private static string OHSUHCREWDQ(LEKSKUSYOLN a, Func<LEKSKUSYOLN, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83BA110", Offset = "0x83B9510", VA = "0x1883BA110")]
		public static string PKEDHWITCAS(this LEKSKUSYOLN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83B9E20", Offset = "0x83B9220", VA = "0x1883B9E20")]
		public static ViewId MONDUIDJDPZ(this LEKSKUSYOLN a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83B9CF0", Offset = "0x83B90F0", VA = "0x1883B9CF0")]
		public static string IBFOHCJRTBD(this LEKSKUSYOLN a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class JFPAWTCVXKE
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class GPZWELHUIZW
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string IJTTIKUCEQL;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83BC760", Offset = "0x83BBB60", VA = "0x1883BC760")]
		public static string GONMOYGJJOX(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(HNTEXQYMSKF), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class HNTEXQYMSKF : KXMXCULKMAC
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log YSABBPNIJBI;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log WHCMTESIHRP;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log QVNHQWJKUOL;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] MTSMVKHGVTS
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA4080", Offset = "0xAA3480", VA = "0x180AA4080", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83BC470", Offset = "0x83BB870", VA = "0x1883BC470", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83BC300", Offset = "0x83BB700", VA = "0x1883BC300", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83BBFF0", Offset = "0x83BB3F0", VA = "0x1883BBFF0")]
		private void DZBVEXJOFHE(LEKSKUSYOLN a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83BC000", Offset = "0x83BB400", VA = "0x1883BC000")]
		private void FMPRJHVMIUD(LEKSKUSYOLN a, YTJXGECMSCM b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83BC030", Offset = "0x83BB430", VA = "0x1883BC030")]
		public void HNBSPMMGNER(LEKSKUSYOLN a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83BC250", Offset = "0x83BB650", VA = "0x1883BC250")]
		private static Log OPHYBKMJNZV(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83BC680", Offset = "0x83BBA80", VA = "0x1883BC680")]
		public HNTEXQYMSKF()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class FEYZZJDWQNC
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
		private static readonly JsonSerializerSettings HZQJEPYPDJD;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83BA540", Offset = "0x83B9940", VA = "0x1883BA540")]
		public static EventWriter FSEOYNYCCOP([In] this EventWriter evt, LEKSKUSYOLN a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83BB080", Offset = "0x83BA480", VA = "0x1883BB080")]
		public static EventWriter KQIQSYIWXMI([In] this EventWriter evt, LEKSKUSYOLN a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83BB9C0", Offset = "0x83BADC0", VA = "0x1883BB9C0")]
		public static string YQJHYPQIRQX(LEKSKUSYOLN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83BB570", Offset = "0x83BA970", VA = "0x1883BB570")]
		public static string OZXGENMPKKC(LEKSKUSYOLN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83BB3D0", Offset = "0x83BA7D0", VA = "0x1883BB3D0")]
		public static string MIHZNXWRSSE(LEKSKUSYOLN a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83BB930", Offset = "0x83BAD30", VA = "0x1883BB930")]
		[CompilerGenerated]
		internal static bool RTPGNEUORYE([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83BB7D0", Offset = "0x83BABD0", VA = "0x1883BB7D0")]
		[CompilerGenerated]
		internal static bool RTLHEHLFCGJ([Out] string a, <>c__DisplayClass6_0 b)
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
