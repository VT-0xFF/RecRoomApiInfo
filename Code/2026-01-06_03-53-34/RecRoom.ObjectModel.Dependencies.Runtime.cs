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
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F18D0", Offset = "0x84F02D0", VA = "0x1884F18D0")]
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
	[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84EFD90", Offset = "0x84EE790", VA = "0x1884EFD90", Slot = "4")]
		public override void JIBLBJTHOBM()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000005")]
		[Cpp2IlInjected.Address(RVA = "0xAE07F0", Offset = "0xADF1F0", VA = "0x180AE07F0")]
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
			[Cpp2IlInjected.Address(RVA = "0xABECF0", Offset = "0xABD6F0", VA = "0x180ABECF0", Slot = "4")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000007")]
		[Cpp2IlInjected.Address(RVA = "0x1F321F0", Offset = "0x1F30BF0", VA = "0x181F321F0", Slot = "5")]
		public override void SetServiceCategoryIndices(List<int> globalFromLocalIndices)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000008")]
		[Cpp2IlInjected.Address(RVA = "0x84F2A80", Offset = "0x84F1480", VA = "0x1884F2A80")]
		private void ANRTHLCVEKO(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000009")]
		[Cpp2IlInjected.Address(RVA = "0x84F2E20", Offset = "0x84F1820", VA = "0x1884F2E20")]
		private void ANXAERWSNVX(IServiceRegistration a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000A")]
		[Cpp2IlInjected.Address(RVA = "0x84F3130", Offset = "0x84F1B30", VA = "0x1884F3130", Slot = "6")]
		public override void RegisterServices(IServiceRegistration registry, [In] ServiceBitsetFilter filter)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x600000B")]
		[Cpp2IlInjected.Address(RVA = "0x84F31E0", Offset = "0x84F1BE0", VA = "0x1884F31E0")]
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
				[Cpp2IlInjected.Address(RVA = "0x84ED790", Offset = "0x84EC190", VA = "0x1884ED790", Slot = "4")]
				get
				{
					return default(NetworkEventType);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000003")]
			public PlayerId BGOLHFMHQPY
			{
				[Cpp2IlInjected.Token(Token = "0x600000F")]
				[Cpp2IlInjected.Address(RVA = "0x84EDC00", Offset = "0x84EC600", VA = "0x1884EDC00", Slot = "5")]
				get
				{
					return default(PlayerId);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000004")]
			public bool INPCLBMKAYN
			{
				[Cpp2IlInjected.Token(Token = "0x6000010")]
				[Cpp2IlInjected.Address(RVA = "0xB00160", Offset = "0xAFEB60", VA = "0x180B00160", Slot = "6")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000005")]
			private bool VKOYWJMNVGM
			{
				[Cpp2IlInjected.Token(Token = "0x6000012")]
				[Cpp2IlInjected.Address(RVA = "0x84ED7E0", Offset = "0x84EC1E0", VA = "0x1884ED7E0", Slot = "7")]
				get
				{
					return default(bool);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x6000011")]
			[Cpp2IlInjected.Address(RVA = "0x84EE380", Offset = "0x84ECD80", VA = "0x1884EE380", Slot = "9")]
			public bool YESTEVOLMYV([Out] PlayerId a)
			{
				return default(bool);
			}

			[Cpp2IlInjected.Token(Token = "0x6000013")]
			[Cpp2IlInjected.Address(RVA = "0xAB8A50", Offset = "0xAB7450", VA = "0x180AB8A50", Slot = "8")]
			public object BWGNCVYQTYV()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000014")]
			[Cpp2IlInjected.Address(RVA = "0x84EDC50", Offset = "0x84EC650", VA = "0x1884EDC50", Slot = "10")]
			private (PlayerId, object) NJFTHPBVFJZ()
			{
				return default((PlayerId, object));
			}

			[Cpp2IlInjected.Token(Token = "0x6000015")]
			[Cpp2IlInjected.Address(RVA = "0x84EDDE0", Offset = "0x84EC7E0", VA = "0x1884EDDE0", Slot = "11")]
			private (ObjectNetworkId, PlayerId) PLYUZNHKLHV()
			{
				return default((ObjectNetworkId, PlayerId));
			}

			[Cpp2IlInjected.Token(Token = "0x6000016")]
			[Cpp2IlInjected.Address(RVA = "0x84EE250", Offset = "0x84ECC50", VA = "0x1884EE250", Slot = "12")]
			private HSCAJZCBIKG<(ObjectNetworkId, PlayerId)> UMPLVUZIPQW()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x6000017")]
			[Cpp2IlInjected.Address(RVA = "0x84ED9E0", Offset = "0x84EC3E0", VA = "0x1884ED9E0", Slot = "13")]
			private (OutOfBandMessageType, byte[]) FTJGCCWBSTA()
			{
				return default((OutOfBandMessageType, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000018")]
			[Cpp2IlInjected.Address(RVA = "0x84EDED0", Offset = "0x84EC8D0", VA = "0x1884EDED0", Slot = "14")]
			private (PacketSource, byte[]) SXRJEDGSDJL()
			{
				return default((PacketSource, byte[]));
			}

			[Cpp2IlInjected.Token(Token = "0x6000019")]
			[Cpp2IlInjected.Address(RVA = "0x3C40DB0", Offset = "0x3C3F7B0", VA = "0x183C40DB0", Slot = "15")]
			public a NXHPRIKAHQK<a>()
			{
				return (a)null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001A")]
			[Cpp2IlInjected.Address(RVA = "0x84EE160", Offset = "0x84ECB60", VA = "0x1884EE160", Slot = "3")]
			public override string ToString()
			{
				return null;
			}

			[Cpp2IlInjected.Token(Token = "0x600001B")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
				[Cpp2IlInjected.Address(RVA = "0x84EE4A0", Offset = "0x84ECEA0", VA = "0x1884EE4A0", Slot = "5")]
				get
				{
					return default(int);
				}
			}

			[Cpp2IlInjected.Token(Token = "0x17000007")]
			public (ObjectNetworkId view, PlayerId newOwner) this[int index]
			{
				[Cpp2IlInjected.Token(Token = "0x600001D")]
				[Cpp2IlInjected.Address(RVA = "0x84EE4C0", Offset = "0x84ECEC0", VA = "0x1884EE4C0", Slot = "4")]
				get
				{
					return default((ObjectNetworkId, PlayerId));
				}
			}

			[Cpp2IlInjected.Token(Token = "0x600001E")]
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public CJLFOJZJGIK()
			{
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600000C")]
		[Cpp2IlInjected.Address(RVA = "0x84F2540", Offset = "0x84F0F40", VA = "0x1884F2540", Slot = "4")]
		public bool ZMUPFJICOJR(object a, QFXHPYQAMQU b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x600000D")]
		[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F1DB0", Offset = "0x84F07B0", VA = "0x1884F1DB0", Slot = "4")]
		public void InitReferences(BDQJEHGTRBM services)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000020")]
		[Cpp2IlInjected.Address(RVA = "0x84F23A0", Offset = "0x84F0DA0", VA = "0x1884F23A0", Slot = "5")]
		public void ShutdownReferences()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000021")]
		[Cpp2IlInjected.Address(RVA = "0x84F21B0", Offset = "0x84F0BB0", VA = "0x1884F21B0", Slot = "6")]
		public void QXEMCEFWOIW(PacketSource a, ReadOnlySpan<byte> b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000022")]
		[Cpp2IlInjected.Address(RVA = "0x84F1C30", Offset = "0x84F0630", VA = "0x1884F1C30", Slot = "10")]
		public void FLBWZYHEONB(PacketSource a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000023")]
		[Cpp2IlInjected.Address(RVA = "0x84F19B0", Offset = "0x84F03B0", VA = "0x1884F19B0", Slot = "7")]
		public void EBFHHTFMBCQ(ReadOnlySpan<PacketSource> a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000024")]
		[Cpp2IlInjected.Address(RVA = "0x84F1E90", Offset = "0x84F0890", VA = "0x1884F1E90")]
		private IDictionary<object, object> OPOXLNERXCV(IDictionary<object, object> a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000025")]
		[Cpp2IlInjected.Address(RVA = "0x84F1950", Offset = "0x84F0350", VA = "0x1884F1950")]
		public void CBQQHQMHGPE(object a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000026")]
		[Cpp2IlInjected.Address(RVA = "0x84F1BC0", Offset = "0x84F05C0", VA = "0x1884F1BC0", Slot = "8")]
		private void EFSYMFFESBS(BDQJEHGTRBM a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000027")]
		[Cpp2IlInjected.Address(RVA = "0xD5FF40", Offset = "0xD5E940", VA = "0x180D5FF40", Slot = "9")]
		private void MIIBQCGEILO()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000028")]
		[Cpp2IlInjected.Address(RVA = "0x84F24C0", Offset = "0x84F0EC0", VA = "0x1884F24C0")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x600002B")]
		[Cpp2IlInjected.Address(RVA = "0x84F29D0", Offset = "0x84F13D0", VA = "0x1884F29D0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F1690", Offset = "0x84F0090", VA = "0x1884F1690", Slot = "19")]
		protected override IList<JsonProperty> CreateProperties(Type type, MemberSerialization memberSerialization)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600002E")]
		[Cpp2IlInjected.Address(RVA = "0x84F1880", Offset = "0x84F0280", VA = "0x1884F1880")]
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
			[Cpp2IlInjected.Address(RVA = "0xABD9C0", Offset = "0xABC3C0", VA = "0x180ABD9C0")]
			public KSOSAENBDBW()
			{
			}

			[Cpp2IlInjected.Token(Token = "0x600003E")]
			[Cpp2IlInjected.Address(RVA = "0x84EECD0", Offset = "0x84ED6D0", VA = "0x1884EECD0")]
			internal string UTIQOFOUFUP(LWCFHEHHVPK a)
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000032")]
		[Cpp2IlInjected.Address(RVA = "0x84EF760", Offset = "0x84EE160", VA = "0x1884EF760")]
		public static string XBOVJQLKGBZ(this LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000033")]
		[Cpp2IlInjected.Address(RVA = "0x84EF630", Offset = "0x84EE030", VA = "0x1884EF630")]
		public static NetworkEventType PYZYNTKUTOQ(this LWCFHEHHVPK a)
		{
			return default(NetworkEventType);
		}

		[Cpp2IlInjected.Token(Token = "0x6000034")]
		[Cpp2IlInjected.Address(RVA = "0x84EF210", Offset = "0x84EDC10", VA = "0x1884EF210")]
		public static ViewId HULPLXJRHDJ(this LWCFHEHHVPK a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000035")]
		[Cpp2IlInjected.Address(RVA = "0x84EF000", Offset = "0x84EDA00", VA = "0x1884EF000")]
		public static string DSZUVEOMCUZ(this LWCFHEHHVPK a, JsonSerializerSettings b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000036")]
		[Cpp2IlInjected.Address(RVA = "0x84EF430", Offset = "0x84EDE30", VA = "0x1884EF430")]
		private static string OJTTYEYUWIL(LWCFHEHHVPK a, Func<LWCFHEHHVPK, string> b)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000037")]
		[Cpp2IlInjected.Address(RVA = "0x84EF0C0", Offset = "0x84EDAC0", VA = "0x1884EF0C0")]
		public static string HLPAVWJHMGV(this LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000038")]
		[Cpp2IlInjected.Address(RVA = "0x84EEE10", Offset = "0x84ED810", VA = "0x1884EEE10")]
		public static ViewId AQJKCGEMNRQ(this LWCFHEHHVPK a)
		{
			return default(ViewId);
		}

		[Cpp2IlInjected.Token(Token = "0x6000039")]
		[Cpp2IlInjected.Address(RVA = "0x84EF520", Offset = "0x84EDF20", VA = "0x1884EF520")]
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
		[Cpp2IlInjected.Address(RVA = "0x84EF780", Offset = "0x84EE180", VA = "0x1884EF780")]
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
			[Cpp2IlInjected.Address(RVA = "0xAB8A60", Offset = "0xAB7460", VA = "0x180AB8A60", Slot = "6")]
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		[Cpp2IlInjected.Token(Token = "0x6000042")]
		[Cpp2IlInjected.Address(RVA = "0x84EE9A0", Offset = "0x84ED3A0", VA = "0x1884EE9A0", Slot = "9")]
		public override void OnEnable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000043")]
		[Cpp2IlInjected.Address(RVA = "0x84EE830", Offset = "0x84ED230", VA = "0x1884EE830", Slot = "10")]
		public override void OnDisable()
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000044")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB10", Offset = "0x84ED510", VA = "0x1884EEB10")]
		private void TLRGHQNEMTD(LWCFHEHHVPK a)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000045")]
		[Cpp2IlInjected.Address(RVA = "0x84EEB20", Offset = "0x84ED520", VA = "0x1884EEB20")]
		private void YOUKCGVJMTC(LWCFHEHHVPK a, TGLBYERUDJN b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000046")]
		[Cpp2IlInjected.Address(RVA = "0x84EE610", Offset = "0x84ED010", VA = "0x1884EE610")]
		public void DBJHRJGQFVC(LWCFHEHHVPK a, DataSourceTags b)
		{
		}

		[Cpp2IlInjected.Token(Token = "0x6000047")]
		[Cpp2IlInjected.Address(RVA = "0x84EE560", Offset = "0x84ECF60", VA = "0x1884EE560")]
		private static Log BEGXCOTHTIQ(byte a)
		{
			return default(Log);
		}

		[Cpp2IlInjected.Token(Token = "0x6000048")]
		[Cpp2IlInjected.Address(RVA = "0x84EEBF0", Offset = "0x84ED5F0", VA = "0x1884EEBF0")]
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
		[Cpp2IlInjected.Address(RVA = "0x84F0470", Offset = "0x84EEE70", VA = "0x1884F0470")]
		public static EventWriter LFEYKKSVAIA([In] this EventWriter evt, LWCFHEHHVPK a, DataSourceTags b)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004B")]
		[Cpp2IlInjected.Address(RVA = "0x84F0FB0", Offset = "0x84EF9B0", VA = "0x1884F0FB0")]
		public static EventWriter NAPQEAZVBGD([In] this EventWriter evt, LWCFHEHHVPK a)
		{
			return default(EventWriter);
		}

		[Cpp2IlInjected.Token(Token = "0x600004C")]
		[Cpp2IlInjected.Address(RVA = "0x84F0290", Offset = "0x84EEC90", VA = "0x1884F0290")]
		public static string KFAOYEZEUKY(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004D")]
		[Cpp2IlInjected.Address(RVA = "0x84EFE90", Offset = "0x84EE890", VA = "0x1884EFE90")]
		public static string GHYWARKIJQD(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x600004E")]
		[Cpp2IlInjected.Address(RVA = "0x84F00F0", Offset = "0x84EEAF0", VA = "0x1884F00F0")]
		public static string HPQFVUIQGAT(LWCFHEHHVPK a)
		{
			return null;
		}

		[Cpp2IlInjected.Token(Token = "0x6000050")]
		[Cpp2IlInjected.Address(RVA = "0x84F12F0", Offset = "0x84EFCF0", VA = "0x1884F12F0")]
		[CompilerGenerated]
		internal static bool UXOXQOIZYBJ([Out] string a, <>c__DisplayClass6_0 b)
		{
			return default(bool);
		}

		[Cpp2IlInjected.Token(Token = "0x6000051")]
		[Cpp2IlInjected.Address(RVA = "0x84F1380", Offset = "0x84EFD80", VA = "0x1884F1380")]
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
