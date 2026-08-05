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
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		[Cpp2IlInjected.Address(RVA = "0x8440410", Offset = "0x843F810", VA = "0x188440410")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class SVGWPJOUYUE
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
	[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
	public SVGWPJOUYUE()
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
		[Cpp2IlInjected.Address(RVA = "0x8440310", Offset = "0x843F710", VA = "0x188440310", Slot = "4")]
		public override void SHWXSEAJSCT()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xACE190", Offset = "0xACD590", VA = "0x180ACE190")]
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
		private int[] DTCBHPALRHU;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] DTHIEVUJATD;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset GTGGRGPIZNX;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset GTAZTZVLQCO;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] TIMZBNQBDOA;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAAA030", Offset = "0xAA9430", VA = "0x180AAA030", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1EBC810", Offset = "0x1EBBC10", VA = "0x181EBC810", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x8443780", Offset = "0x8442B80", VA = "0x188443780")]
		private void RGTQLMDRHIR(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x8443480", Offset = "0x8442880", VA = "0x188443480")]
		private void RGOJOFJTXXI(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x8443B30", Offset = "0x8442F30", VA = "0x188443B30", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x8443BE0", Offset = "0x8442FE0", VA = "0x188443BE0")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(HXMSWNWJIXV), new string[] { "Photon" })]
	public class CFKYMNDKMYW : HXMSWNWJIXV
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class YLDGKLEZVZO : WYHSPCAVTMD
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public PTKTLSUVJWP HHFDOBLSVGK;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public StatusCode VQAHTJYFZAJ;

			[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public JWYKTRFYPPZ NUOIYLYKKLV;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType IRYCWFFEKLI
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x84433D0", Offset = "0x84427D0", VA = "0x1884433D0", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId GQNZJUUOZCL
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x8443380", Offset = "0x8442780", VA = "0x188443380", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool BBANKANJADO
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0x8442980", Offset = "0x8441D80", VA = "0x188442980", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool PYXORUQNQID
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x84427C0", Offset = "0x8441BC0", VA = "0x1884427C0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x8442B20", Offset = "0x8441F20", VA = "0x188442B20", Slot = "9")]
			public bool OQKLXIJKRSY([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0x8443330", Offset = "0x8442730", VA = "0x188443330", Slot = "8")]
			public object VGYXWVDDEMS()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x8442990", Offset = "0x8441D90", VA = "0x188442990", Slot = "10")]
			private (PlayerId, object) MXLWBESPRLY()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x8443020", Offset = "0x8442420", VA = "0x188443020", Slot = "11")]
			private (ObjectNetworkId, PlayerId) RFADPCFWJIO()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x8443110", Offset = "0x8442510", VA = "0x188443110", Slot = "12")]
			private GOLWLRVZMXJ<(ObjectNetworkId, PlayerId)> RTZOBSQNAUJ()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x8442BE0", Offset = "0x8441FE0", VA = "0x188442BE0", Slot = "13")]
			private (OutOfBandMessageType, byte[]) PJHIDBNMIBP()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x8442E00", Offset = "0x8442200", VA = "0x188442E00", Slot = "14")]
			private (PacketSource, byte[]) QDKHXCUVQVQ()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C53920", Offset = "0x3C52D20", VA = "0x183C53920", Slot = "15")]
			public a LNMLXVWBCMZ<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x8443240", Offset = "0x8442640", VA = "0x188443240", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public YLDGKLEZVZO()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class JWYKTRFYPPZ : GOLWLRVZMXJ<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x4000010")]
			public int[] COMTEGXRNJG;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int WFHQKHTXLMO
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x8440250", Offset = "0x843F650", VA = "0x188440250", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x8440270", Offset = "0x843F670", VA = "0x188440270", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public JWYKTRFYPPZ()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x843E170", Offset = "0x843D570", VA = "0x18843E170", Slot = "4")]
		public bool WNIWTQLPHSC(object a, WYHSPCAVTMD b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
		public CFKYMNDKMYW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class RUGIFDDLOIF
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(NFLNVFYPGNE), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : UFLUIPVILQU, DUFVPRZKCTS, NFLNVFYPGNE, TUMMHZEQETT, LZXVIVBNZGR
	{
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		private static readonly Log HONKOTEDSFS;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private RUOFXNRWHDG AWBSSZSCGNB;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		[DependsOn]
		private APAKMFNBAVV UZIJKMGVNCT;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private readonly Hashtable SLXSHSCOUJB;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x8440560", Offset = "0x843F960", VA = "0x188440560", Slot = "4")]
		public void InitReferences(SAMXOKXXSFT services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84409B0", Offset = "0x843FDB0", VA = "0x1884409B0", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x8440A50", Offset = "0x843FE50", VA = "0x188440A50", Slot = "6")]
		public void UGYUGOVCWIR(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x8440890", Offset = "0x843FC90", VA = "0x188440890", Slot = "10")]
		public void RIADYDXZKVA(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x8440BB0", Offset = "0x843FFB0", VA = "0x188440BB0", Slot = "7")]
		public void XONETNVMYNB(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x8440640", Offset = "0x843FA40", VA = "0x188440640")]
		private Hashtable OLHKCNOYFYK(Hashtable a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x8440500", Offset = "0x843F900", VA = "0x188440500")]
		public void FUUJLGJITVX(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x8440490", Offset = "0x843F890", VA = "0x188440490", Slot = "8")]
		private void EEVWSJPJMZT(SAMXOKXXSFT a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD15010", Offset = "0xD14410", VA = "0x180D15010", Slot = "9")]
		private void BFZHWFFBFON()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x8440DC0", Offset = "0x84401C0", VA = "0x188440DC0")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.TUXZQOHZVJL), new string[] { })]
	internal class DPNZLTAEFHS : MKVNZWJSBFA, RecRoom.RoomLoading.RoomOperation.TUXZQOHZVJL
	{
		[Cpp2IlInjected.Token(Token = "0x4000015")]
		private static readonly Log IGFPCUTJBRF;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] JGBZXPVFNJC
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x843E340", Offset = "0x843D740", VA = "0x18843E340")]
		public DPNZLTAEFHS()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class BPZPTXVSQSP : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x843DF30", Offset = "0x843D330", VA = "0x18843DF30", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x843E120", Offset = "0x843D520", VA = "0x18843E120")]
		public BPZPTXVSQSP()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class VSXDHSRSAZC
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class JLSEUHBSZCB
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public JsonSerializerSettings AKEULRNWBPV;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAAC8E0", Offset = "0xAABCE0", VA = "0x180AAC8E0")]
			public JLSEUHBSZCB()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x8440110", Offset = "0x843F510", VA = "0x188440110")]
			internal string WFOHUOBWYUC(PTKTLSUVJWP a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x8441130", Offset = "0x8440530", VA = "0x188441130")]
		public static string BXABUTWHBPC(this PTKTLSUVJWP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x8441560", Offset = "0x8440960", VA = "0x188441560")]
		public static NetworkEventType XBCTBMOQTPV(this PTKTLSUVJWP a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x8441850", Offset = "0x8440C50", VA = "0x188441850")]
		public static ViewId ZGZYAMGTYTQ(this PTKTLSUVJWP a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x8441150", Offset = "0x8440550", VA = "0x188441150")]
		public static string DBYWPZIRJOQ(this PTKTLSUVJWP a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x8441470", Offset = "0x8440870", VA = "0x188441470")]
		private static string WDRCROVCFCC(PTKTLSUVJWP a, Func<PTKTLSUVJWP, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x8441210", Offset = "0x8440610", VA = "0x188441210")]
		public static string INWJCZRRTWO(this PTKTLSUVJWP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x8441690", Offset = "0x8440A90", VA = "0x188441690")]
		public static ViewId ZGDOEVIREGD(this PTKTLSUVJWP a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x8441360", Offset = "0x8440760", VA = "0x188441360")]
		public static string UKKAFNFCYPX(this PTKTLSUVJWP a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class YCHYTEXQJDO
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class ZBSSKUUUYUU
		{
			[Cpp2IlInjected.Token(Token = "0x400001C")]
			public static string OBAVPYYGRFR;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x84421B0", Offset = "0x84415B0", VA = "0x1884421B0")]
		public static string EBTVHXALFSL(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(XCMBCPOURUR), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class XCMBCPOURUR : MKVNZWJSBFA
	{
		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log IUZUVSVGTUG;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log XMRPBDQADFD;

		[Cpp2IlInjected.Token(Token = "0x400001F")]
		private static readonly Log SUNVVUTJLZF;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] JGBZXPVFNJC
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAAB1C0", Offset = "0xAAA5C0", VA = "0x180AAB1C0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x8441EC0", Offset = "0x84412C0", VA = "0x188441EC0", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x8441D50", Offset = "0x8441150", VA = "0x188441D50", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x8441D40", Offset = "0x8441140", VA = "0x188441D40")]
		private void MXQCMXBZCSO(PTKTLSUVJWP a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x8441A40", Offset = "0x8440E40", VA = "0x188441A40")]
		private void FIILOVKSCVF(PTKTLSUVJWP a, FRDJWLZNOWA b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x8441A70", Offset = "0x8440E70", VA = "0x188441A70")]
		public void FJUCFTSLMLL(PTKTLSUVJWP a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x8441C90", Offset = "0x8441090", VA = "0x188441C90")]
		private static Log GQNCUDFEJEL(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84420D0", Offset = "0x84414D0", VA = "0x1884420D0")]
		public XCMBCPOURUR()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class GRKAWMLZVOQ
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
		private static readonly JsonSerializerSettings USHZQVKKTEZ;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x843ED90", Offset = "0x843E190", VA = "0x18843ED90")]
		public static EventWriter RMWQBGAJNOP([In] this EventWriter evt, PTKTLSUVJWP a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x843E3F0", Offset = "0x843D7F0", VA = "0x18843E3F0")]
		public static EventWriter CRUXBZRBFKY([In] this EventWriter evt, PTKTLSUVJWP a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x843EBB0", Offset = "0x843DFB0", VA = "0x18843EBB0")]
		public static string RFZYJZELCMX(PTKTLSUVJWP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x843E7C0", Offset = "0x843DBC0", VA = "0x18843E7C0")]
		public static string NCAOYVUHKMS(PTKTLSUVJWP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x843EA20", Offset = "0x843DE20", VA = "0x18843EA20")]
		public static string PDYLHTALPQI(PTKTLSUVJWP a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x843E730", Offset = "0x843DB30", VA = "0x18843E730")]
		[CompilerGenerated]
		internal static bool MLVYYBZFIOA([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x843FE00", Offset = "0x843F200", VA = "0x18843FE00")]
		[CompilerGenerated]
		internal static bool VKSIWJOZHCB([Out] string a, <>c__DisplayClass6_0 b)
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
