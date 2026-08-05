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
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		[Cpp2IlInjected.Address(RVA = "0x83EE400", Offset = "0x83ECC00", VA = "0x1883EE400")]
		public NullableAttribute(byte P_0)
		{
		}
	}
}
[Cpp2IlInjected.Token(Token = "0x2000004")]
[CompilerGenerated]
[EditorBrowsable(EditorBrowsableState.Never)]
[GeneratedCode("Unity.MonoScriptGenerator.MonoScriptInfoGenerator", null)]
internal class XZYMFDMNRDD
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
	[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
	public XZYMFDMNRDD()
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
		[Cpp2IlInjected.Address(RVA = "0x83EC8B0", Offset = "0x83EB0B0", VA = "0x1883EC8B0", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAC98A0", Offset = "0xAC80A0", VA = "0x180AC98A0")]
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
		private int[] TVXWIVSLKTH;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000008")]
		private int[] TVSPLOYOBHY;

		[Cpp2IlInjected.FieldOffset(Offset = "0x28")]
		[Cpp2IlInjected.Token(Token = "0x4000009")]
		private ServiceBitset EJWMBZOWMVA;

		[Cpp2IlInjected.FieldOffset(Offset = "0x30")]
		[Cpp2IlInjected.Token(Token = "0x400000A")]
		private ServiceBitset EKBSZGITWGJ;

		[Cpp2IlInjected.FieldOffset(Offset = "0x40")]
		[Cpp2IlInjected.Token(Token = "0x400000C")]
		private Type[] QDKJNDDHSLP;

		[Cpp2IlInjected.Token(Token = "0x17000001")]
		public override string[] ServiceCategories
		{
			[Cpp2IlInjected.Token(Token = "0x6000006")]
			[Cpp2IlInjected.Address(RVA = "0xAA7DA0", Offset = "0xAA65A0", VA = "0x180AA7DA0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F1B170", Offset = "0x1F19970", VA = "0x181F1B170", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x83EF5B0", Offset = "0x83EDDB0", VA = "0x1883EF5B0")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x83EF950", Offset = "0x83EE150", VA = "0x1883EF950")]
		private void ANXAERWSNVX(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x83EFC50", Offset = "0x83EE450", VA = "0x1883EFC50", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x83EFD00", Offset = "0x83EE500", VA = "0x1883EFD00")]
		public _AssemblyIndex()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Transmission
{
	[Cpp2IlInjected.Token(Token = "0x2000008")]
	[RegisterService(typeof(GOSJXNFXQPY), new string[] { "Photon" })]
	public class SXHDHFYWDBX : GOSJXNFXQPY
	{
		[Cpp2IlInjected.Token(Token = "0x2000009")]
		private class ALNPZSQURNT : QFXHPYQAMQU
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000D")]
			public LWCFHEHHVPK AMUBQQPQEAR;

			[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
			[Cpp2IlInjected.Token(Token = "0x400000E")]
			public CJLFOJZJGIK SAPSMNZSSDU;

			[Cpp2IlInjected.Token(Token = "0x17000002")]
			public NetworkEventType BFJYMHQJKIL
			{
				[Cpp2IlInjected.Token(Token = "0x600000E")]
				[Cpp2IlInjected.Address(RVA = "0x83EA280", Offset = "0x83E8A80", VA = "0x1883EA280", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId BGOLHFMHQPY
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x83EA6F0", Offset = "0x83E8EF0", VA = "0x1883EA6F0", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool INPCLBMKAYN
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xAE90A0", Offset = "0xAE78A0", VA = "0x180AE90A0", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool VKOYWJMNVGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x83EA2D0", Offset = "0x83E8AD0", VA = "0x1883EA2D0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x83EAE80", Offset = "0x83E9680", VA = "0x1883EAE80", Slot = "9")]
			public bool YESTEVOLMYV([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AA0", Offset = "0xAA02A0", VA = "0x180AA1AA0", Slot = "8")]
			public object BWGNCVYQTYV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x83EA740", Offset = "0x83E8F40", VA = "0x1883EA740", Slot = "10")]
			private (PlayerId, object) NJFTHPBVFJZ()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x83EA8D0", Offset = "0x83E90D0", VA = "0x1883EA8D0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) PLYUZNHKLHV()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x83EAD50", Offset = "0x83E9550", VA = "0x1883EAD50", Slot = "12")]
			private HSCAJZCBIKG<(ObjectNetworkId, PlayerId)> UMPLVUZIPQW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x83EA4C0", Offset = "0x83E8CC0", VA = "0x1883EA4C0", Slot = "13")]
			private (OutOfBandMessageType, byte[]) FTJGCCWBSTA()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x83EA9C0", Offset = "0x83E91C0", VA = "0x1883EA9C0", Slot = "14")]
			private (PacketSource, byte[]) SXRJEDGSDJL()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C29D30", Offset = "0x3C28530", VA = "0x183C29D30", Slot = "15")]
			public a NXHPRIKAHQK<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x83EAC60", Offset = "0x83E9460", VA = "0x1883EAC60", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public ALNPZSQURNT()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x200000A")]
		private class CJLFOJZJGIK : HSCAJZCBIKG<(ObjectNetworkId, PlayerId)>
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400000F")]
			public int[] RUEZSIYVFIH;

			[Cpp2IlInjected.Token(Token = "0x17000006")]
			public int VURRPMXXQNB
			{
				[Cpp2IlInjected.Token(Token = "0x600001C")]
				[Cpp2IlInjected.Address(RVA = "0x83EAFB0", Offset = "0x83E97B0", VA = "0x1883EAFB0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x83EAFD0", Offset = "0x83E97D0", VA = "0x1883EAFD0", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public CJLFOJZJGIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x83EF070", Offset = "0x83ED870", VA = "0x1883EF070", Slot = "4")]
		public bool ZMUPFJICOJR(object a, QFXHPYQAMQU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
		public SXHDHFYWDBX()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x200000B")]
	internal static class ACERPFZTPUK
	{
	}
	[Cpp2IlInjected.Token(Token = "0x200000C")]
	[RegisterService(typeof(HANCHUPFBTZ), new string[] { "Photon" })]
	[AlsoBindServiceAs(typeof(PUNCachedEventPacketTransport))]
	public class PUNCachedEventPacketTransport : IPQERUQWVJD, EEYQRLXJBSJ, HANCHUPFBTZ, TTDQLFCDEXA, TFZKCIODVYK
	{
		[Cpp2IlInjected.Token(Token = "0x4000010")]
		private static readonly Log RKIUKOTABJV;

		[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
		[Cpp2IlInjected.Token(Token = "0x4000011")]
		[DependsOn]
		private DUHHAJAAWFP FZZXZRNVKWC;

		[Cpp2IlInjected.FieldOffset(Offset = "0x18")]
		[Cpp2IlInjected.Token(Token = "0x4000012")]
		[DependsOn]
		private WMNLRBHMESC EFDCBXIFUSG;

		[Cpp2IlInjected.FieldOffset(Offset = "0x20")]
		[Cpp2IlInjected.Token(Token = "0x4000013")]
		private readonly IDictionary<object, object> TTSQGLEVNVM;

		[Cpp2IlInjected.Token(Token = "0x600001F")]
		[Cpp2IlInjected.Address(RVA = "0x83EE8E0", Offset = "0x83ED0E0", VA = "0x1883EE8E0", Slot = "4")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x83EEED0", Offset = "0x83ED6D0", VA = "0x1883EEED0", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x83EECE0", Offset = "0x83ED4E0", VA = "0x1883EECE0", Slot = "6")]
		public void QXEMCEFWOIW(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x83EE760", Offset = "0x83ECF60", VA = "0x1883EE760", Slot = "10")]
		public void FLBWZYHEONB(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x83EE4E0", Offset = "0x83ECCE0", VA = "0x1883EE4E0", Slot = "7")]
		public void EBFHHTFMBCQ(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x83EE9C0", Offset = "0x83ED1C0", VA = "0x1883EE9C0")]
		private IDictionary<object, object> OPOXLNERXCV(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x83EE480", Offset = "0x83ECC80", VA = "0x1883EE480")]
		public void CBQQHQMHGPE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x83EE6F0", Offset = "0x83ECEF0", VA = "0x1883EE6F0", Slot = "8")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD48920", Offset = "0xD47120", VA = "0x180D48920", Slot = "9")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x83EEFF0", Offset = "0x83ED7F0", VA = "0x1883EEFF0")]
		public PUNCachedEventPacketTransport()
		{
		}
	}
}
namespace RecRoom.ObjectModel.Logging
{
	[Cpp2IlInjected.Token(Token = "0x200000D")]
	[RegisterService(typeof(RecRoom.RoomLoading.RoomOperation.AAIJYGAWIBC), new string[] { })]
	internal class VEJOIEDUBFR : EPCYUGGQBET, RecRoom.RoomLoading.RoomOperation.AAIJYGAWIBC
	{
		[Cpp2IlInjected.Token(Token = "0x4000014")]
		private static readonly Log ECYSQPUFJVU;

		[Cpp2IlInjected.Token(Token = "0x17000008")]
		protected override Log[] MQADRBDAAEL
		{
			[Cpp2IlInjected.Token(Token = "0x600002A")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x83EF500", Offset = "0x83EDD00", VA = "0x1883EF500")]
		public VEJOIEDUBFR()
		{
		}
	}
}
namespace RecRoom.ObjectModel.EditorWindows
{
	[Cpp2IlInjected.Token(Token = "0x200000E")]
	public class NUYXLVPNINO : DefaultContractResolver
	{
		[Cpp2IlInjected.Token(Token = "0x600002D")]
		[Cpp2IlInjected.Address(RVA = "0x83EE1C0", Offset = "0x83EC9C0", VA = "0x1883EE1C0", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x83EE3B0", Offset = "0x83ECBB0", VA = "0x1883EE3B0")]
		public NUYXLVPNINO()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000010")]
	public static class KTNENQKUHPX
	{
		[Cpp2IlInjected.Token(Token = "0x2000012")]
		[CompilerGenerated]
		private sealed class KSOSAENBDBW
		{
			[Cpp2IlInjected.FieldOffset(Offset = "0x10")]
			[Cpp2IlInjected.Token(Token = "0x400001A")]
			public JsonSerializerSettings WYISCCUNSYQ;

			[Cpp2IlInjected.Token(Token = "0x600003D")]
			[Cpp2IlInjected.Address(RVA = "0xAA6A60", Offset = "0xAA5260", VA = "0x180AA6A60")]
			public KSOSAENBDBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x83EB7E0", Offset = "0x83E9FE0", VA = "0x1883EB7E0")]
			internal string UTIQOFOUFUP(LWCFHEHHVPK a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x83EC280", Offset = "0x83EAA80", VA = "0x1883EC280")]
		public static string XBOVJQLKGBZ(this LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x83EC140", Offset = "0x83EA940", VA = "0x1883EC140")]
		public static NetworkEventType PYZYNTKUTOQ(this LWCFHEHHVPK a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x83EBD20", Offset = "0x83EA520", VA = "0x1883EBD20")]
		public static ViewId HULPLXJRHDJ(this LWCFHEHHVPK a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x83EBB10", Offset = "0x83EA310", VA = "0x1883EBB10")]
		public static string DSZUVEOMCUZ(this LWCFHEHHVPK a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x83EBF40", Offset = "0x83EA740", VA = "0x1883EBF40")]
		private static string OJTTYEYUWIL(LWCFHEHHVPK a, Func<LWCFHEHHVPK, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x83EBBD0", Offset = "0x83EA3D0", VA = "0x1883EBBD0")]
		public static string HLPAVWJHMGV(this LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x83EB920", Offset = "0x83EA120", VA = "0x1883EB920")]
		public static ViewId AQJKCGEMNRQ(this LWCFHEHHVPK a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x83EC030", Offset = "0x83EA830", VA = "0x1883EC030")]
		public static string PFFJWHDRGVE(this LWCFHEHHVPK a, JsonSerializerSettings b)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000013")]
	public static class LLKENXRFTOX
	{
		[Cpp2IlInjected.Token(Token = "0x2000014")]
		internal static class AVMUKQMPDCT
		{
			[Cpp2IlInjected.Token(Token = "0x400001B")]
			public static string KXKSETDOFRU;
		}

		[Cpp2IlInjected.Token(Token = "0x600003F")]
		[Cpp2IlInjected.Address(RVA = "0x83EC2A0", Offset = "0x83EAAA0", VA = "0x1883EC2A0")]
		public static string EALVVERMYFK(NetworkEventType a)
		{
			return null;
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000015")]
	[RegisterService(typeof(GDZFAGRHKHW), new string[] { })]
	[ServiceLifetime(Lifetime.PhotonRoom)]
	internal class GDZFAGRHKHW : EPCYUGGQBET
	{
		[Cpp2IlInjected.Token(Token = "0x400001C")]
		private static readonly Log BTSTIAIVXSH;

		[Cpp2IlInjected.Token(Token = "0x400001D")]
		private static readonly Log NAKVYNKXQUQ;

		[Cpp2IlInjected.Token(Token = "0x400001E")]
		private static readonly Log TOSWIJBFCWW;

		[Cpp2IlInjected.Token(Token = "0x17000009")]
		protected override Log[] MQADRBDAAEL
		{
			[Cpp2IlInjected.Token(Token = "0x6000041")]
			[Cpp2IlInjected.Address(RVA = "0xAA1AB0", Offset = "0xAA02B0", VA = "0x180AA1AB0", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x83EB4B0", Offset = "0x83E9CB0", VA = "0x1883EB4B0", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x83EB340", Offset = "0x83E9B40", VA = "0x1883EB340", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x83EB620", Offset = "0x83E9E20", VA = "0x1883EB620")]
		private void TLRGHQNEMTD(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x83EB630", Offset = "0x83E9E30", VA = "0x1883EB630")]
		private void YOUKCGVJMTC(LWCFHEHHVPK a, TGLBYERUDJN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x83EB120", Offset = "0x83E9920", VA = "0x1883EB120")]
		public void DBJHRJGQFVC(LWCFHEHHVPK a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x83EB070", Offset = "0x83E9870", VA = "0x1883EB070")]
		private static Log BEGXCOTHTIQ(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x83EB700", Offset = "0x83E9F00", VA = "0x1883EB700")]
		public GDZFAGRHKHW()
		{
		}
	}
	[Cpp2IlInjected.Token(Token = "0x2000016")]
	public static class MUCLDIUMEQP
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
		private static readonly JsonSerializerSettings WJIYOBAMFXA;

		[Cpp2IlInjected.Token(Token = "0x600004A")]
		[Cpp2IlInjected.Address(RVA = "0x83ECF90", Offset = "0x83EB790", VA = "0x1883ECF90")]
		public static EventWriter LFEYKKSVAIA([In] this EventWriter evt, LWCFHEHHVPK a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x83EDAD0", Offset = "0x83EC2D0", VA = "0x1883EDAD0")]
		public static EventWriter NAPQEAZVBGD([In] this EventWriter evt, LWCFHEHHVPK a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x83ECDB0", Offset = "0x83EB5B0", VA = "0x1883ECDB0")]
		public static string KFAOYEZEUKY(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x83EC9B0", Offset = "0x83EB1B0", VA = "0x1883EC9B0")]
		public static string GHYWARKIJQD(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x83ECC10", Offset = "0x83EB410", VA = "0x1883ECC10")]
		public static string HPQFVUIQGAT(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x83EDE20", Offset = "0x83EC620", VA = "0x1883EDE20")]
		[CompilerGenerated]
		internal static bool UXOXQOIZYBJ([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x83EDEB0", Offset = "0x83EC6B0", VA = "0x1883EDEB0")]
		[CompilerGenerated]
		internal static bool ZNIXSVHGUKC([Out] string a, <>c__DisplayClass6_0 b)
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
